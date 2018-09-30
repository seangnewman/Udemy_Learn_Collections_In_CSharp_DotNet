using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var value in GetValues())
            //{
            //    Console.WriteLine(value);
            //}

            var e = GetValues().GetEnumerator();

            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }

        public  static IEnumerable<int> GetValues()
        {
            var value = 1;
            yield return value;
            value++;
            yield return value;
            value++;
            yield return value;

            yield break;

            value++;
            yield return value;
            value++;
            yield return value;


        }

    }
}
