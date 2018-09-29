using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Attributes
{
    class Person
    {
        [DisplayOrder(1)]
        public string FirstName { get; set; }

        [DisplayOrder(0)]
        public string LastName { get; set; }

        
    }
}
