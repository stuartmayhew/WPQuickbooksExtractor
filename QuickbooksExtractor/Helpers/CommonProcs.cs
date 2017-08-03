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
        public static string QBConnStr = "Data Source=13.58.68.10;Initial Catalog=WPAccess;Persist Security Info=True;User ID=sa;Password=Sh@dow111";
        public static string WCompanyConnStr = "Data Source=13.58.68.10;Initial Catalog=WPCompany;Persist Security Info=True;User ID=sa;Password=Sh@dow111";

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

        public static TConvert ConvertTo<TConvert>(this object entity) where TConvert : new()
        {
            var convertProperties = TypeDescriptor.GetProperties(typeof(TConvert)).Cast<PropertyDescriptor>();
            var entityProperties = TypeDescriptor.GetProperties(entity).Cast<PropertyDescriptor>();

            var convert = new TConvert();

            foreach (var entityProperty in entityProperties)
            {
                var property = entityProperty;
                var convertProperty = convertProperties.FirstOrDefault(prop => prop.Name == property.Name);
                if (convertProperty != null)
                {
                    convertProperty.SetValue(convert, Convert.ChangeType(entityProperty.GetValue(entity), convertProperty.PropertyType));
                }
            }

            return convert;
        }
    }
}
 