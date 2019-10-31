using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Homework
{
    class Body:AbstractParts
    {
        string content;
        public override string Content
        {
            get
            {
                if (string.IsNullOrEmpty(content))
                {
                    return "Empty field!";
                }
                else
                { return content; }
            }
            set
            {
                content = value;
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
