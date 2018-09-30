using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "hello", "world", "cake", "pie"
            };


            // Of course, the foreach is much easier
            using (var e = list.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }

            
        }
    }
}
