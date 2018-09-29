using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection_Demo
{
    class EmployeeCollection : KeyedCollection<int, Employee>
    {
        

        protected override int GetKeyForItem(Employee item)
        {
            return item.Id;
        }

        
    }
}
