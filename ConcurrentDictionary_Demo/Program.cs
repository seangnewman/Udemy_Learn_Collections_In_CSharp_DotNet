using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ConcurrentDictionary_Demo
{
    class Program
    {
        static ConcurrentDictionary<int, string> _dictionary = new ConcurrentDictionary<int, string>();
        static void Main(string[] args)
        {

            _dictionary.TryAdd(1, "hello");
            _dictionary.TryAdd(2, "world");

            var t1 = new Thread(new ThreadStart(A));
            var t2 = new Thread(new ThreadStart(B));
            var t3 = new Thread(new ThreadStart(C));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            _dictionary.AddOrUpdate(7, "raptor", (k, v) => v + "2"); //7, raptor
            _dictionary.AddOrUpdate(7, "raptor", (k, v) => v + "2"); //7, raptor

           var cat =  _dictionary.GetOrAdd(8, "dog");
            cat = _dictionary.GetOrAdd(8, "fish"); // fails and remains cat

        }

        static void A()
        {
            _dictionary.TryAdd(3, "foo");
        }

        static void B()
        {
            var value = String.Empty;
            _dictionary.TryRemove(1, out value);
        }

        static void C()
        {
            var value = String.Empty;
            _dictionary.TryUpdate(2, "world 2", "world3"); // fail
            _dictionary.TryUpdate(2, "world 2", "world"); // pass
        }

    }
}
