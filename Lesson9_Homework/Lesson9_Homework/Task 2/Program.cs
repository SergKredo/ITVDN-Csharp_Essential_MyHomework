using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
        /*Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
    вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два
    аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку
    деления на ноль.
    Написать программу, которая будет выполнять арифметические действия, указанные пользователем.*/
    class Program
    {
        public delegate double CalculationNumbers(double a, double b);  // Объявление класса-делегата с сообщающимся методом, который принимает три параметра типа double и возвращает значение типа double
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение основных арифметических операций с числами:".ToUpper());
            Again:
            Console.WriteLine(new string('-', 50));
            Console.Write("Первое число: ");
            double oneNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число: ");
            double twoNumber = Convert.ToDouble(Console.ReadLine());
            CalculationNumbers add = (double one, double two) => { return one + two; }; // Экземпляр класса-делегата, хранящий указатель на анонимный метод(лямбда-оператор), возвращающий результат операции сложения двух чисел
            CalculationNumbers sub = (double one, double two) => { return one - two; }; // Экземпляр класса-делегата, хранящий указатель на анонимный метод(лямбда-оператор), возвращающий результат операции вычитания двух чисел
            CalculationNumbers mul = (double one, double two) => { return one * two; }; // Экземпляр класса-делегата, хранящий указатель на анонимный метод(лямбда-оператор), возвращающий результат операции умножения двух чисел
            CalculationNumbers div = (double one, double two) =>
            {
                if (two != 0)                      // Условная конструкция для проверки условия деления на нуль
                {
                    return one / two;
                }
                else
                {
                    Console.WriteLine("Невозможно деление на нуль!");
                    return 0;
                }
            };                                                                          // Экземпляр класса-делегата, хранящий указатель на анонимный метод(лямбда-оператор), выполняющий возвращающий результат операции деления двух чисел

            Console.WriteLine("Результат операций:".ToUpper());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Сложение: {0}+{1} = ".ToUpper() + add(oneNumber, twoNumber), oneNumber, twoNumber);
            Console.WriteLine("Вычитание: {0}-{1} = ".ToUpper() + sub(oneNumber, twoNumber), oneNumber, twoNumber);
            Console.WriteLine("Умножение: {0}*{1} = ".ToUpper() + mul(oneNumber, twoNumber), oneNumber, twoNumber);
            Console.WriteLine("Деление: {0}/{1} = ".ToUpper() + div(oneNumber, twoNumber), oneNumber, twoNumber);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(new string('-', 50));
            goto Again;

        }
    }
}
