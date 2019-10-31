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
    Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, 
    среднее арифметическое всех элементов, вывести все нечетные значения.*/
    class Program
    {
        static void Main(string[] args)
        {   
            Again: // Метка для возврата программы после выполнения
            Console.Write("Введите разрядность массива: ");
            string n = Console.ReadLine();  // Введение строкового значения разрядности одномерного массива
            if (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Вы ввели неправильную разрядность массива! Введите пожалуйста заново!\n");
                goto Again;
            }
            int number = Convert.ToInt32(n);
            if (number <= 0)
            {
                Console.WriteLine("Вы ввели неправильную разрядность массива! Введите пожалуйста заново!\n");
            }
            else
            {
                int[] massive = new int[number];      // Передача массиву разрядности
                Massive massiveme = new Massive(massive);  // Создание экземпляра класса Massive c передачей формального параметра в пользовательский конструктор класса в виде массива чисел
                massiveme.MaxNumber();  // Вызов метода на экземпляре
                massiveme.MinNumber();
                massiveme.Sum();
                massiveme.ArithmeticMean();
                massiveme.OddValues();
            }
            goto Again;  // Повторная реализация кода программы
            

        
        }
    }
}
