using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;     // Импорт в проект собственного пространства имен



namespace MyNamespace  // Создание собственного пространства имен
{
    static class MyClass   // Статический класс
    {
        public static string ExtensionMethod(this string param)   // Расширяющий метод для конкатенации входящего аргумента с заданным выражением литералов
        {
            return "*****" + param + "*****";
        }
    }
}


namespace Additional_Task
{
    /*Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом
приложении.*/
    class Program
    {
        static void Main(string[] args)
        {
            while (true)  // Бесконечный цикл
            {
                Console.WriteLine(new string('-', 30));
                Console.Write(string.Format("Enter the word: ".ToUpper()));
                string word = Console.ReadLine();
                Console.WriteLine(string.Format("Result after extension method: {0}", word.ExtensionMethod()));  // Использование расширяющего метода для введенного пользователем выражения
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
