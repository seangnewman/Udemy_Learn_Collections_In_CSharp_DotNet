using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingList_Demo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            //return $"{LastName}, {FirstName}";
            return string.Format("{0}, {1}", LastName, FirstName);
        }
    }
}
