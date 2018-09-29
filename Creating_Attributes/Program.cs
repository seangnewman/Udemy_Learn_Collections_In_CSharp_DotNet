using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Donald",
                LastName = "Blake"
            };

            var output = CsvConvert.ToCsv(person);

            Console.WriteLine(output);
        }
    }
}
