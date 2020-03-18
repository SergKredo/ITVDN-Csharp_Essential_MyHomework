using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
        /*Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте класс Calculator.
    В теле класса создайте четыре метода для арифметических действий: (Add – сложение, Sub – вычитание,
    Mul – умножение, Div – деление).
    Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать
    исключение.
    Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.
    При возникновении ошибок должны выбрасываться исключения.*/

    // Пользовательский класс генерации исключения
    class MyException : Exception   // Наследование от базового класса Exception
    {
        string message = null;
        public MyException(string message) : base(message)  // Инициализация членов базового и пользовательского конструкторов
        {
            this.message = message;
        }
        public override string Message           // Переопределение свойства Message базового класса Exception. Возвращает сообщение об ошибке с объяснением причин исключения или пустую строку ("")
        {
            get
            {
                return this.message;
            }
        }
    }

    // Пользовательский класс для выполнения арифметических действий над числами
    class Calculator
    {
        public float Add(float numberOne, float numberTwo)  // Метод для сложения двух чисел
        {
            return numberOne + numberTwo;
        }
        public float Sub(float numberOne, float numberTwo)   // Метод для вычитания двух чисел
        {
            return numberOne - numberTwo;
        }
        public float Mul(float numberOne, float numberTwo)   // Метод для умножения двух чисел
        {
            return numberOne * numberTwo;
        }
        public float Div(float numberOne, float numberTwo)    // Метод для деления двух чисел
        {
            return numberOne / numberTwo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();   // Создание экземпляра класса Calculator
            float numberOne, numberTwo;                   // Объявление переменных с плавающей запятой
            string myException = null;
            Console.ForegroundColor = ConsoleColor.Red;
            string calculatorExceptions = "Calculator with Exceptions:".ToUpper();
            Console.WriteLine(calculatorExceptions.PadLeft(35));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));
            while (true)                                // Бесконечный цикл while для повторения арифметических действий над числами
            {
            Again:                 // Метка возврата

                // Конструкция try-catch-finally для обработки исключений
                try
                {
                    Console.Write("Enter the number one: ");
                    numberOne = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException e)      // Оператор catch принимает в качестве параметра из блока try сгенерированный экземпляр исключения типа FormatException
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(e.Message);
                    goto Again;
                }
                finally
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            AgainTwo:             // Метка возврата
                try
                {
                    Console.Write("Enter the number Two: ");
                    numberTwo = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(e.Message);
                    goto AgainTwo;
                }
                finally
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            AgainThree:               // Метка возврата
                try
                {
                    Console.Write("Specify the type of arithmetic operation: ");
                    string signOperation = Console.ReadLine();
                    switch (signOperation)   // Конструкция switch для перебора верного значения принятого в качестве параметра
                    {
                        case "/":
                            {
                                if (numberTwo == 0)   // Условная конструкция, которая говорит о том, что деление на нуль невозможно
                                {
                                    myException = "The operation of division by zero is impossible!";
                                    throw new MyException(myException);    // Оператор throw генерирует экземпляр пользовательского исключения по слабой ссылке и далее передает его  в блок catch в качестве входящего аргумента 
                                }
                                Console.WriteLine("Result: {0} / {1} = {2}", numberOne, numberTwo, myCalculator.Div(numberOne, numberTwo));
                                break;
                            }
                        case "+":
                            {
                                Console.WriteLine("Result: {0} + {1} = {2}", numberOne, numberTwo, myCalculator.Add(numberOne, numberTwo));
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine("Result: {0} - {1} = {2}", numberOne, numberTwo, myCalculator.Sub(numberOne, numberTwo));
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine("Result: {0} * {1} = {2}", numberOne, numberTwo, myCalculator.Mul(numberOne, numberTwo));
                                break;
                            }
                        default:
                            {
                                // В случее неверного ввода основных знаков арифметичсеких операций формируется новое пользовательское исключение
                                myException = "You entered the wrong sign for an arithmetic operation!";
                                throw new MyException(myException);
                            }
                    }
                }
                catch (MyException e)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(e.Message);
                    goto AgainThree;   // Возврат оператором goto действий программы в положение метки AgainThree
                }
                finally
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(new string('-', 50));  // Подчеркивание штрих-пунктирной линией из 50 литералов
                Console.WriteLine(new string('-', 50));

            }
        }
    }
}
