using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void MyDelegate(string str);
    public class Program
    {
        public static event MyDelegate TextAdd;

        static void Main(string[] args)
        {
            new Presenter();  // Для статического класса нельзя передать ссылку на себя (this) в конструкторе
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    TextAdd.Invoke(str);
                }
            }
        }
    }
}
