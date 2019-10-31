using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content
    {
        string contentBook;

        public string ContentBook
        {
            set
            {
                contentBook = value;
            }
            get
            {
                return contentBook;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ContentBook);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
