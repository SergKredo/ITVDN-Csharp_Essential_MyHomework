using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
        /*Дополнительное задание
    Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать статический класс Calculator, с методами для выполнения основных арифметических
    операций.
    Написать программу, которая выводит на экран основные арифметические операции.*/
    class Program
    {
        static void Main(string[] args)
        {
            string heading = "Основные арифметические операции с чифрами:";
            Console.WriteLine(string.Format(heading.ToUpper()));
            Again:
            Console.Write("Введите два числа:\nNUMBER 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("NUMBER 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine(new string('-', 30));
            Calculator.AdditionMethod(number1, number2);
            Calculator.SubtractionMethod(number1, number2);
            Calculator.MultiplicationMethod(number1, number2);
            Calculator.DivisionMethod(number1, number2);
            if (number2 == 0)
            {
                goto Again;
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            goto Again;
        }
    }
}
