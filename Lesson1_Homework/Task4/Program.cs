using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника.*/
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1.5, 1, "A"), new Point(1.5, 3, "B"), new Point(3, 5, "C"), new Point(5, 3, "D"), new Point(3.5, 1, "E"));
            Console.Write("Type figure: {0}\nPerimeter figure = ", figure.Type);
            figure.CalculatorPerimeter();

            Console.ReadKey();
        }
    }
}
