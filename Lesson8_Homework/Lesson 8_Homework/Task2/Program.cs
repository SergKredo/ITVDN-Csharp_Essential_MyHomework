using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
        /*Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте статический класс с методом void Print (string stroka, int color), который выводит на
    экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных
    пользователю. Ввод строки и выбор цвета предоставьте пользователю.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для изменения цвета текста:".ToUpper());
            Console.WriteLine(new string('-', 100));
            Console.Write("Введите нужный Вам текст: ".ToUpper());
            string text = Console.ReadLine();
            Console.Write("Выберите цвет текста - введите номер от 0 до 15: ".ToUpper());
            int number = Convert.ToInt32(Console.ReadLine());
            for (MyClass.Color colorNumber = MyClass.Color.Black; colorNumber <= MyClass.Color.Yellow; colorNumber++)
            {
                if ((int)colorNumber == number)
                { 
                Console.WriteLine("Поздравляем! Вы выбрали {0} цвет!", colorNumber);
                break;
                }
            }
            Console.Write("Введенный Вами текст в заданном цвете: ".ToUpper());
            MyClass.Print(text, number);
            Console.WriteLine(new string('-', 100));
            MyClass.AllPrint(text);
            Console.ReadKey();
            
        }
    }
}
