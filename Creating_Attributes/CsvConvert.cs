using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Attributes
{
    public static class CsvConvert
    {
        public static string ToCsv(object obj)
        {
            var type = obj.GetType();
            var attributeType = typeof(DisplayOrderAttribute);

            var properties = type.GetProperties()
                .Where(p => Attribute.IsDefined(p, attributeType))
                .ToArray();

            var csv = new string[properties.Length];

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(attributeType, true)
                    .Cast<DisplayOrderAttribute>()
                    .ToArray();

                foreach (var attribute in attributes)
                {
                    var value = property.GetValue(obj);
                    var position = attribute.Position;
                    csv[position] = value?.ToString() ?? string.Empty;
                }
            }

            return string.Join(",", csv);
        }
    }
}
