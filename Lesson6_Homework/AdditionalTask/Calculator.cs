using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    static class Calculator
    {
        public static void AdditionMethod(double number1, double number2)
        {
            Console.WriteLine("Addition: {0}{1}{2} = {3};", number1,'+', number2,(number1+number2));
        }
        public static void SubtractionMethod(double number1, double number2)
        {
            Console.WriteLine("Subtraction: {0}{1}{2} = {3};", number1, '-', number2, (number1 - number2));
        }
        public static void MultiplicationMethod(double number1, double number2)
        {
            Console.WriteLine("Multiplication: {0}{1}{2} = {3};", number1, '*', number2, (number1 * number2));
        }
        public static void DivisionMethod(double number1, double number2)
        {
            if (number2 != 0)
            {
                Console.WriteLine("Division: {0}{1}{2} = {3};", number1, '/', number2, (number1 / number2));
            }
            else
            {
                Console.WriteLine("Division: "+"Внимание! Деление на нуль запрещено!\nПовторите пожалуйста операцию с делением!");
                Console.WriteLine(new string('-', 30));
            }
        }

    }
}
