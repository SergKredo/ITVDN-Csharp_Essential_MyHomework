using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте структуру описывающую точку в трехмерной системе координат. Организуйте возможность
сложения двух точек, через использование перегрузки оператора +.*/

    // Структура для формирования точек в трехмерной системе координат
    struct Point
    {

        public float X { get; set; } // Автосвойство точки с координатой X
        public float Y { get; set; }  // Автосвойство точки с координатой Y
        public float Z { get; set; }   // Автосвойство точки с координатой Z

        public Point(float[] point)   // Пользовательский конструктор с входящим параметром в виде массива
        {
            this.X = point[0];
            this.Y = point[1];
            this.Z = point[2];
        }


         // Метод оператор+ для перегрузкия оператора +
        public static Point operator +(Point one, Point Two)
        {
            float[] massiveSumPoints =
            {
                one.X+Two.X,
                one.Y+Two.Y,
                one.Z+Two.Z
            };                                     // Одномерный массив, элементы которого проинициализированы значениями суммой координат от двух точек

            return new Point(massiveSumPoints);    // Возвращает новый экземпляр типа Point, экземпляр которого принимает аргумент типа массив
        }
        public override string ToString()          // Переопределение базового метода ToString класса Object
        {
            return string.Format("Point C as a result of adding the coordinates of points A, B has: ({0}; {1}; {2});", X, Y, Z);
        }
    }

    class Program
    {
        // Статический метод для последовательного вывода строки в консоли и записи значений координат точек
        static void AddChar(out float[] point, string numberPoint, char namePoint)
        {
            float[] pointMymassive = new float[3];
            numberPoint = numberPoint.Insert(numberPoint.IndexOf(':'), " " + namePoint.ToString());
            for (int i = 0; i < pointMymassive.Length; i++)
            {
                Console.Write(numberPoint);
                pointMymassive[i] = Convert.ToSingle(Console.ReadLine());
                if (i == 2)
                {
                    numberPoint += pointMymassive[i].ToString() + ");";
                    --Console.CursorTop;
                    Console.WriteLine(numberPoint);
                    break;
                }
                numberPoint += pointMymassive[i].ToString() + "; ";
                --Console.CursorTop;
            }
            point = pointMymassive;
        }

        static void Main(string[] args)
        {
            float[] pointA = new float[3];   // Одномерный массив, элементы которого принимают значения координат введенные пользователем в консоли
            float[] pointB = new float[3];
            char a = 'A';
            char b = 'B';
            string onePoint = "Enter the coordinates of point: (";
            Console.WriteLine(string.Format("Coordinates of a point in a three-dimensional coordinate system:".ToUpper().PadLeft(70)));
            Console.WriteLine(new string('-', 100));
            while (true)                      // Бесконечное повторение цикла ввода координат точек
            {
                AddChar(out pointA, onePoint, a);    
                Point pointOne = new Point(pointA);
                AddChar(out pointB, onePoint, b);
                Point pointTwo = new Point(pointB);

                Point pointThree = pointOne + pointTwo;   // Значения координат точки C после перегрузки оператора+
                Console.WriteLine(new string('-', 100));
                Console.WriteLine(pointThree);
                Console.WriteLine(new string('*', 100));
            }
        }
    }
}
