using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
        /*Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и
    возвращает среднее арифметическое этих аргументов.*/
    class Program
    {
        public delegate int Calculation(int a, int b, int c); // Объявление класса-делегата с сообщающимся методом, который принимает три целочисленных параметра и возвращает целочисленное значение
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста 3-и любых числа:".ToUpper());
            Console.WriteLine(new string('-', 50));
            Again:
            Console.Write("Первое число: ");
            int oneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int twoNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число: ");
            int threeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));
            Console.Write("Среднее арифметическое чисел: ({0}+{1}+{2})/3 = ".ToUpper(), oneNumber, twoNumber, threeNumber);
            Calculation calculation  = delegate (int one, int two, int three) { return (one + two + three) / 3; };  // Присвоение к экземпляру класса-делегата анонимного метода, который удовлетворяет условиям сигнатуры сообщающегося метода класса-делегата
            int result = calculation(oneNumber, twoNumber, threeNumber);
            Console.Write(result+"\n");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(new string('-', 50));
            goto Again;
        }
    }
}
