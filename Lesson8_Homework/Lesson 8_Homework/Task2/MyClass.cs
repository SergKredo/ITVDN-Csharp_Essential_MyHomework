using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class MyClass   // Статический класс
    {

        public enum Color     // Перечисление именованых констант цветов форматирования цвета текста консоли
        { 
            Black = ConsoleColor.Black,   // Присвоение значения цвета консоли к объявленной константе
            Blue = ConsoleColor.Blue,
            Cyan = ConsoleColor.Cyan,
            DarkBlue = ConsoleColor.DarkBlue,
            DarkCyan = ConsoleColor.DarkCyan,
            DarkGray = ConsoleColor.DarkGray,
            DarkGreen = ConsoleColor.DarkGreen,
            DarkMagenta = ConsoleColor.DarkMagenta,
            DarkRed = ConsoleColor.DarkRed,
            DarkYellow = ConsoleColor.DarkYellow,
            Gray = ConsoleColor.Gray,
            Green = ConsoleColor.Green,
            Magenta = ConsoleColor.Magenta,
            Red = ConsoleColor.Red,
            White = ConsoleColor.White,
            Yellow = ConsoleColor.Yellow
        }
        public static void Print(string stroka, int color)  // Метод для выведения в консоли текста с заданным цветом
        {
            for (Color colorNumber = Color.Black; colorNumber <= Color.Yellow; colorNumber++)
            {
                if (color == (int)colorNumber)
                {
                    Console.ForegroundColor = (ConsoleColor)colorNumber;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
            }
        }
        public static void AllPrint(string stroka)  // Метод для выведения  консоли текста с массивом имеющихся цветов
        {
            Console.WriteLine("Текст во всех цветах форматирования консоли:".ToUpper());
            for (Color colorNumber = Color.Black; colorNumber <= Color.Yellow; colorNumber++)
            {
                    Console.Write(colorNumber+" [{0}]: ", (int)colorNumber);
                    Console.ForegroundColor = (ConsoleColor)colorNumber;
                    Console.Write(stroka+"\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
