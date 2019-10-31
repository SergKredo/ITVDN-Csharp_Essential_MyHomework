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
    Создайте класс AbstractHandler.
    В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
    Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
    AbstractHandler.
    Написать программу, которая будет выполнять определение документа и для каждого формата
    должны быть методы открытия, создания, редактирования, сохранения определенного
    формата документа.*/
    class Program
    {
        static void Main(string[] args)
        {
            Again:
            Console.WriteLine(new string('-', 85));
            Console.Write("Выберите пожалуйста из списка (DOC, TXT, XML) нужный Вам тип документа: ");
            string format = Console.ReadLine();
            Console.Write("Выберите пожалуйста функционал этого документа (OPEN, CREATE, CHANGE, SAVE): ");
            string functional = Console.ReadLine();
            Console.WriteLine(new string('-', 85));
            Console.Write("Поздравляем! ");

            FormatDocument formatDocument = new FormatDocument(format, functional); // Экземпляр класса (объект)
            Console.WriteLine();
            Console.WriteLine(new string('-', 85));
            goto Again;



        }
    }
}
