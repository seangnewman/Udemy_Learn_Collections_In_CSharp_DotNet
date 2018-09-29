using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenNumbers = new EvenNumberCollection();

            evenNumbers.Add(2);
            evenNumbers.Add(8);
            evenNumbers.Add(5);

            Console.WriteLine(evenNumbers.Count);

            evenNumbers[1] = 7;
            Console.WriteLine(evenNumbers[1]);


        }
    }
}
