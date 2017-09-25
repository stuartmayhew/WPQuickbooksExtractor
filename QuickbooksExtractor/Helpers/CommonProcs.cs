using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QuickbooksExtractor.Helpers
{
    public static class CommonProcs
    {
        public static string QBConnStr = "Data Source=52.15.204.7;Initial Catalog=WPAccess;Persist Security Info=True;User ID=sa;Password=Sh@dow111;Connection Timeout=600";
        public static string WCompanyConnStr = "Data Source=52.15.204.7;Initial Catalog=WPCompany;Persist Security Info=True;User ID=sa;Password=Sh@dow111;Connection Timeout=600;Max Pool Size=1000;";

        public static string TimeStampString(DateTime date)
        {
            string tsString = " {ts '" + date.ToString("yyyy-MM-dd") + " 00:00:00.000'}";
            return tsString;
        }

        public static string DateString(DateTime date)
        {
            string tsString = " {d '" + date.ToString("yyyy-MM-dd") + "'}";
            return tsString;
        }

        public static TConvert ConvertTo<TConvert>(this object entity,bool hasMapped = false,string tableName = "") where TConvert : new()
        {
            var convertProperties = TypeDescriptor.GetProperties(typeof(TConvert)).Cast<PropertyDescriptor>();
            var entityProperties = TypeDescriptor.GetProperties(entity).Cast<PropertyDescriptor>();

            var convert = new TConvert();

            foreach (var entityProperty in entityProperties)
            {
                var property = entityProperty;
                string mappedName = "";
                if (hasMapped)
                    mappedName = MapName(property.Name, tableName);
                else
                    mappedName = property.Name;
                var convertProperty = convertProperties.FirstOrDefault(prop => prop.Name == mappedName);
                if (convertProperty != null)
                {
                    if (entityProperty.GetValue(entity) != null)
                        convertProperty.SetValue(convert, Convert.ChangeType(entityProperty.GetValue(entity), convertProperty.PropertyType));
                    else
                    {
                        switch (convertProperty.PropertyType.Name)
                        {
                            case "decimal":
                                convertProperty.SetValue(convert, 0.0M);
                                break;
                        }

                    }
                }
            }

            return convert;
        }

        public static string MapName(string name, string tableName)
        {
            string sql = "SELECT WPField FROM FieldMap WHERE ";
            string returnName = "";
            sql += "WPTable='" + tableName + "' ";
            sql += "AND QBField = '" + name + "'";
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                returnName = dg.GetScalarString(sql);
                if (returnName == string.Empty)
                    returnName = name;
            }
            return returnName;
        }
    }
}
 