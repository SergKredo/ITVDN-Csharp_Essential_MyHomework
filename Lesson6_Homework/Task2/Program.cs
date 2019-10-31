using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
        /*Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для
    поиска по книге из примера урока 005_Delegation. При вызове этого метода, производится
    последовательный поиск строки в книге.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(new string('-', 120));
            string headline = "Поиск слов из текста:";
            headline = headline.PadLeft(70);
            Console.WriteLine(headline.ToUpper());
            Console.Write(new string('-', 120)+"\n");
            Console.WriteLine("Выбранный Вами текст:\n\n{0}", FindAndReplaceManager.sampletext);
            Console.Write(new string('-', 120));
            Again:
            Console.Write("\nВведите пожалуйста нужное Вам слово: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string find = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(new string('-', 120));
            if (string.IsNullOrEmpty(find))
            {
                Console.WriteLine("Вы не ввели слово! Повторите пожалуйста эту операцию заново!");
                Console.Write(new string('-', 120));
                goto Again;
            }
            Console.WriteLine("\nВывод в тексте заданного слова: \n");
            FindAndReplaceManager.FindNext(find);
            
            Console.Write(new string('*', 120));
            Console.Write(new string('*', 120));
            Console.Write(new string('-', 120));
            goto Again;
            
        }
    }
}
