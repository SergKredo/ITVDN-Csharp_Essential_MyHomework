using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Print: {0}", value);
        }
        
    }
}
