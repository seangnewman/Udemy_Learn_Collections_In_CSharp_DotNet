using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ObservableCollection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var stuff = new ObservableCollection<string>();

            stuff.CollectionChanged += Stuff_CollectionChanged;

            stuff.Add("Hello");
            stuff.Add("World");

            stuff.Remove("Hello");


        }

        private static void Stuff_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    var value = (string)item;
                    Console.WriteLine("{0} was added to the collection", value);
                }
            }

            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems)
                {
                    var value = (string)item;
                    Console.WriteLine("{0} was removed to the collection", value);
                }
            }

        }
    }
}
