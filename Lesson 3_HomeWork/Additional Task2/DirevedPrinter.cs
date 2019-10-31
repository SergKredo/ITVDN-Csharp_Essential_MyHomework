using System;
using System.Collections.Generic;
using System.Text;

namespace Additional_Task2
{
    class DirevedPrinter: Printer
    {

        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Method DerivedClass1: {0}", value);
        }
    }
}
