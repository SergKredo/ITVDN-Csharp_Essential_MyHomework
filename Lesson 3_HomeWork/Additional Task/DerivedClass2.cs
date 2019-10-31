using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class DerivedClass2: DerivedClass1
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("DerivedClass2: {0}", value);
        }
    }
}
