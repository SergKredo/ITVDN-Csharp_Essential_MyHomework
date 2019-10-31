using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется: Создать класс с именем Rectangle.
В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
поля side1 и side2 инициализируются значениями аргументов.
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
прямоугольника - double PerimeterCalculator().
Создать два свойства double Area и double Perimeter с одним методом доступа get.
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
на экран периметр и площадь.*/

    class Rectangle
    {
        double side1, side2;       // Поля, характеризующие значение сторон прямоугольника
        public Rectangle(double side1, double side2)    // Пользовательский конструктор с двумя принимаемыми аргументами от пользователя
        {
            this.side1 = side1;       // Инициализация полей
            this.side2 = side2;
        }
        double AreaCalculator()     // Метод для расчета площади прямоугольника
        {
            double area = side1 * side2;
            return area;
        }
        double PerimeterCalculator()   // Метод для расчета периметра прямоугольника
        {
            double perimeter = 2 * (side1 + side2);
            return perimeter;
        }
        public double Area                  // Свойство только чтения, возвращает значения метода расчета площади прямоугольника
        {
            get
            {
                return AreaCalculator();        // Аксессор
            }
        }
        public double Perimeter              // Свойство только чтения, возвращает значения метода расчета периметра прямоугольника
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 55));    // Выводит набор штриховых символов
            Console.WriteLine("Calculate the area and the perimeter for the rectangle:");
            Console.Write("Width of the rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());     // Ввод пользователем с клавиатуры значения ширины прямоугольника
            Console.Write("Height of the rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());     // Ввод пользователем с клавиатуры значения высоты прямоугольника

            Rectangle rectangle = new Rectangle(side1, side2);   // Создание экземпляра класса Rectangle с двумя заданными параметрами
            Console.WriteLine("Area of the rectangle: {0}", rectangle.Area);    // Вывод на экран значения площади прямоугольника
            Console.WriteLine("Perimeter of the rectangle: {0}", rectangle.Perimeter);  // Вывод на экран значения периметра прямоугольника
            Console.WriteLine(new string('-', 55));

            Console.ReadKey();

        }
    }
}
