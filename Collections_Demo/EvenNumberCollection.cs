using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    class EvenNumberCollection: FilteredCollection<int>
    {

        public EvenNumberCollection() : base(i => i % 2 == 0)
        {
           
        }
         
    }
}
