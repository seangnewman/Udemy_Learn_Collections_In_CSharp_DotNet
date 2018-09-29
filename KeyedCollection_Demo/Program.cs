using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new EmployeeCollection();

            employees.Add(new Employee { Id = 1, Name = "Cody" });
            employees.Add(new Employee { Id = 2, Name = "Connor" });

            Console.WriteLine(employees[1].Name);
        }
    }
}
