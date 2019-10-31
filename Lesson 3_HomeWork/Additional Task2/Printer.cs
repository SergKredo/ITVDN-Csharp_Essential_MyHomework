using System;
using System.Collections.Generic;
using System.Text;

namespace Additional_Task2
{
    class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Method Printer: {0}", value);
        }
    }
}
