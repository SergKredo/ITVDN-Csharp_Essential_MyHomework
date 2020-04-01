using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Additional_Task
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа
dynamic.*/


    class Calculator  // Создание класса калькулятора
    {
        public dynamic Add(dynamic numberOne, dynamic numberTwo)  // Метод арифметичсекой операции суммирования двух чисел. Метод принимает два динамических параметра и возвращает динамический тип данных
        {
            try   // Блок try-catch для обработки исключения
            {
                numberOne = Convert.ToDouble(numberOne);  //Конвертирование значения входящего параметра в тип double
                numberTwo = Convert.ToDouble(numberTwo);
                return numberOne + numberTwo;
            }
            catch
            {
                return string.Format("Data values of the arguments do not support the operation of addition!");
            }
        }
        public dynamic Sub(dynamic numberOne, dynamic numberTwo)  // Метод арифметичсекой операции вычитания двух чисел. Метод принимает два динамических параметра и возвращает динамический тип данных
        {
            try
            {
                numberOne = Convert.ToDouble(numberOne);
                numberTwo = Convert.ToDouble(numberTwo);
                return numberOne - numberTwo;
            }
            catch
            {
                return string.Format("Data values of the arguments do not support the operation of subtraction!");
            }
        }
        public dynamic Mul(dynamic numberOne, dynamic numberTwo)  // Метод арифметичсекой операции умножения двух чисел. Метод принимает два динамических параметра и возвращает динамический тип данных
        {
            try
            {
                numberOne = Convert.ToDouble(numberOne);
                numberTwo = Convert.ToDouble(numberTwo);
                return numberOne * numberTwo;
            }
            catch
            {
                return string.Format("Data values of the arguments do not support the operation of multiplication!");
            }
        }
        public dynamic Div(dynamic numberOne, dynamic numberTwo)  // Метод арифметической операции деления двух чисел. Метод принимает два динамических параметра и возвращает динамический тип данных
        {
            try
            {
                numberOne = Convert.ToDouble(numberOne);
                numberTwo = Convert.ToDouble(numberTwo);
                numberTwo = (numberTwo == 0) ? "Division by zero is not possible!" : numberTwo;  // Тернарная конструкция для определения операции деления на нуль
                if (!(numberTwo is String))
                {
                    return numberOne / numberTwo;
                }
                else
                {
                    return numberTwo;
                }
            }
            catch
            {
                return string.Format("Data values of the arguments do not support the operation of multiplication!");
            }
        }


        public dynamic SignOperation(dynamic sign, dynamic numberOne, dynamic numberTwo)  // Метод, который позволяет по знаку ариф.операции определяет вызов метода ариф. операции
        {
            switch (sign)
            {
                case "+":
                    {
                        return Add(numberOne, numberTwo);
                    }
                case "-":
                    {
                        return Sub(numberOne, numberTwo);
                    }
                case "*":
                    {
                        return Mul(numberOne, numberTwo);
                    }
                case "/":
                    {
                        return Div(numberOne, numberTwo);
                    }
                default:
                    {
                        return string.Format("You have entered the wrong sign for an arithmetic operation!");
                    }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Calculator on the basis of dynamic types: ".ToUpper()));
            Console.WriteLine(new string('-', 50));
            while (true)
            {
                Console.Write("First number: ");
                dynamic firstNumber = Console.ReadLine();
                Console.Write("Second number: ");
                dynamic secondNumber = Console.ReadLine();
                Calculator calculator = new Calculator();
                Console.Write("Enter the sign of the arithmetic operation: ");
                dynamic sign = Console.ReadLine();
                Console.WriteLine("Result: {0}", calculator.SignOperation(sign, firstNumber, secondNumber));
                Console.WriteLine(new string('*', 50));
                Console.WriteLine(new string('*', 50));
            };
        }
    }
}
