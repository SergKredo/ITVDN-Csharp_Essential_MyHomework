using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Homework
{
        /*Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: Изменить 12 пример первого урока (работа с документом) и создать общий
    абстрактный класс для всех частей документа.*/
    class Program
    {
        static void Main(string[] args)
        {
            string title = "C# programming.";
            string footer = "Alex Shevchuk. C# developer.";
            string body = "This book about C# language and OOP programming....";
            Document document = new Document(title, footer, body);
            document.Show();
            

            Console.ReadKey();
            
        }
    }
}
