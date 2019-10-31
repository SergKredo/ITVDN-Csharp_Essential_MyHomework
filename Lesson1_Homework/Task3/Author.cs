using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author
    {
        string nameAuthor;

        public string NameAuthor
        {
            set
            {
                nameAuthor = value;
            }
            get
            {
                return nameAuthor;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(NameAuthor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
