using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Reflection;

namespace QuickbooksExtractor.Helpers
{
    public class ReaderToModel<T>
    {
        public virtual List<T> CreateList(string sql, string connStr)
        {
            var results = new List<T>();
            using (clsDataGetter dg = new clsDataGetter(connStr))
            {
                SqlDataReader reader = dg.GetDataReader(sql);
                var NotMapped = new List<String>();

                var props = typeof(T).GetProperties();
                foreach (var prop in props)
                {
                    NotMapped.Add(prop.Name);
                }

                while (reader.Read())
                {
                    var item = Activator.CreateInstance<T>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if (!NotMapped.Contains(property.Name))
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                    }
                    results.Add(item);
                }
                dg.KillReader(reader);
            }
            return results;
        }

        public virtual T CreateModel(string sql, string connStr)
        {
            var results = new List<T>();
            using (clsDataGetter dg = new clsDataGetter(connStr))
            {
                SqlDataReader reader = dg.GetDataReader(sql);
                var NotMapped = new List<String>();

                var props = typeof(T).GetProperties();
                foreach (var prop in props)
                {
                    NotMapped.Add(prop.Name);
                }

                while (reader.Read())
                {
                    var item = Activator.CreateInstance<T>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if (!NotMapped.Contains(property.Name))
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                    }
                    results.Add(item);
                }
                dg.KillReader(reader);
            }
            return results[0];
        }
    }

    public class ModelToSQL<T>
    {
        public virtual int WriteInsertSQL(string tableName, T ModelToSubmit, string pKeyName, string connStr)
        {

            int newSubmitID = -1;

            var NotMapped = new List<String>();

            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                NotMapped.Add(prop.Name);
            }
            NotMapped.Add(pKeyName);

            string sql = "INSERT INTO " + tableName + "(";
            var properties = typeof(T).GetProperties();
            sql = sql.Substring(0, sql.Length - 1);
            sql += ") VALUES(";
            foreach (var prop in properties)
            {
                {
                    if (!NotMapped.Contains(prop.Name))
                    {
                        var propertyType = prop.PropertyType;
                        if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            propertyType = propertyType.GetGenericArguments()[0];
                        }

                        var value = ModelToSubmit.GetType().GetProperty(prop.Name).GetValue(ModelToSubmit);
                        if (propertyType.Name == "Int32")
                        {
                            if (value == null)
                                value = 0;
                            sql += value + ",";
                        }
                        if (propertyType.Name == "Decimal")
                        {
                            if (value == null)
                                value = 0.0M;
                            sql += value + ",";
                        }
                        else if (propertyType.Name == "String")
                        {
                            if (value == null)
                                value = "";
                            sql += "'" + FSQ(value.ToString()) + "',";
                        }
                        else if (propertyType.Name == "Boolean")
                        {
                            if (value == null)
                                value = false;
                            sql += ConvertToBool((bool)value) + ",";
                        }

                        else if (propertyType.Name == "DateTime")
                        {
                            if (value == null)
                                value = DateTime.Now.ToShortDateString();
                            sql += "'" + value + "',";
                        }
                    }
                }
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";
            using (clsDataGetter dg = new clsDataGetter(connStr))
            {
                try
                {
                    dg.RunCommand(sql);
                }
                catch(Exception ex)
                {
                    string x = ex.Message;
                }
                newSubmitID = dg.GetScalarInteger("SELECT MAX(" + pKeyName + ") FROM " + tableName);
            }
            return newSubmitID;
        }

        public string ConvertToBool(bool value)
        {
            if (value)
                return "1";
            else
                return "0";
        }

        public string FSQ(string s)
        {
            if (s != null && s != string.Empty)
                return s.Replace("'", "''");
            else
                return "";
        }
    }
}
