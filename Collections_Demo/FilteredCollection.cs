using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    class FilteredCollection<T> : Collection<T>
    {
        private readonly Func<T, bool> _filter;

        public FilteredCollection(Func<T, bool> filter)
        {
            _filter = filter;
        }

        protected override void InsertItem(int index, T item)
        {
            if (_filter(item))
            {
                base.InsertItem(index, item);
            }

        }

        protected override void SetItem(int index, T item)
        {
            if (_filter(item))
            {
                base.SetItem(index, item);
            }
        }
    }

   
}
