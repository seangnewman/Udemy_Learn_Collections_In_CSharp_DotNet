using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingList_Demo
{
    public static class DataSource
    {
        public static IEnumerable<Person> GetPeople()
        {
            var list = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe" },
                new Person {FirstName = "Jim", LastName = "Smith" },
                new Person {FirstName = "Tim", LastName = "Johnson" },
                new Person {FirstName = "Jane", LastName = "Roberson" },
                new Person {FirstName = "Bob", LastName = "Smith" }
            };

            return list.ToArray();
        }
    }
}
