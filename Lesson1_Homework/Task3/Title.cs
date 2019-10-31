using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title
    {
        string titlebook;

        public string TitleBook
        {
            set
            {
                titlebook = value;
            }
                get
            {
                return titlebook;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(TitleBook);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
