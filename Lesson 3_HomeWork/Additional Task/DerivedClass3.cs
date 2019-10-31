using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class DerivedClass3: DerivedClass2
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DerivedClass3: {0}", value);
        }
    }
}
