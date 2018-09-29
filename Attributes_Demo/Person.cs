using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Attributes_Demo
{

    class Person
    {
        [XmlAttribute(AttributeName = "firstName")]
        public string FirstName { get; set; }

        [XmlAttribute(AttributeName = "lastName")]
        public string LastName { get; set; }
    }
}
