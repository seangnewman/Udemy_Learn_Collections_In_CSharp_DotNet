using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Attributes_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage("Hello, World!");
        }
        
        [Obsolete("Use DisplayAndLogMessage", false) ]
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void DisplayAndLogMessage(string message)
        {
            Console.WriteLine(message);

            // TODO : log message
        }
    }
}
