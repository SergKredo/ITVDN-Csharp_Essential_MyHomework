using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
            /*Задание 4
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Требуется:
        Создайте класс DocumentWorker.
        В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
        тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
        "Редактирование документа доступно в версии Про", "Сохранение документа доступно в
        версии Про".
        Создайте производный класс ProDocumentWorker.
        Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
        "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
        форматах доступно в версии Эксперт".
        Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
        Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
        "Документ сохранен в новом формате".
        В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
        Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
        экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
        создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.*/
    class Program
    {
        static void Main(string[] args)
        {   Again:
            Console.Write("Введите пожалуйста номер ключа доступа к версии PRO: ");
            string pro = Console.ReadLine();
            Console.Write("Введите пожалуйста номер ключа доступа к версии EXP: ");
            string exp = Console.ReadLine();
            ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
            Console.WriteLine(new string('-', 60));

            if (exp == expertDocumentWorker.ExpNumber)
            {
                Console.WriteLine("Вы можете пользоваться EXP версией программы!");
                Console.WriteLine("Вам будут доступны все функции программы:");
                expertDocumentWorker.OpenDocument();
                expertDocumentWorker.EditDocument();
                expertDocumentWorker.SaveDocument();
            }
            if (pro == expertDocumentWorker.ProNumber)
            {
                ProDocumentWorker proDocumentWorker = expertDocumentWorker;
                Console.WriteLine("Вы можете пользоваться PRO версией программы!");
                Console.WriteLine("Вам будут доступны неполные функции программы:");
                proDocumentWorker.OpenDocument();
                proDocumentWorker.EditDocument();
                proDocumentWorker.SaveDocument();
            }
            
            if (pro != expertDocumentWorker.ProNumber && exp != expertDocumentWorker.ExpNumber)
            {
                Console.WriteLine("Вы можете пользоваться только бесплатной версией программы!");
                Console.WriteLine("Вам будут доступны сильно ограниченные функции программы:");
                DocumentWorker documentWorker = expertDocumentWorker;
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(new string('-', 60));
            }
            goto Again;
        }
    }
}
