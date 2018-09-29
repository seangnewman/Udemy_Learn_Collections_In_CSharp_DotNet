using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[]
            {
                "Joe", "Moe", "Low"
            };
            var list1 = new List<string>(names);
            var list2 = new List<string>
            {
                "Moe", "Larry"
            };

            var list3 = new List<string>();

            list3.Add("Mary");

            list3.Count();
            list3.AddRange(names);

        }
    }
}
