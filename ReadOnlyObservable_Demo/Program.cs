using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ReadOnlyObservable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new ObservableCollection<string>();
            INotifyCollectionChanged ro = new ReadOnlyObservableCollection<string>(o);

            ro.CollectionChanged += Ro_CollectionChanged;
            

        }

        private static void Ro_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
