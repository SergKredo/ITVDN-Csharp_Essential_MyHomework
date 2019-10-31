using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
        /*Задание 4
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы
    массива по возрастанию.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 150));
            string heading = "Расширяющие методы для целочисленного массива.";
            Console.WriteLine(heading.ToUpper().PadLeft(70));
            Console.WriteLine(new string('-', 150));
            Again:
            for (int a = 0; a < 3; a++)
            {
            Console.Write("Введите разрядность массива {0}: ", a+1);
            int size = Convert.ToInt32(Console.ReadLine());
            int[] massive = new int[size];
            Random random = new Random();    
            for (int i = 0; i < massive.Length; i++)  // Инициализация элементов массива случайными числами, используя класс Random
            {
                massive[i] = random.Next(0, 150);  // Выборка случайных чисел от нуля до 100
            }
            Console.Write(" - Результат сортировки элементов массива с наименьшего до наибольшего значений {0}: ", a+1);
            massive.SortMassiveLessToBigger();                  // Применение расширяющегося метода на массиве
            Console.Write(" - Результат сортировки элементов массива с наибольшего до наименьшего значений {0}: ", a + 1);
            massive.SortMassiveBiggerToLess();                  // Применение расширяющегося метода на массиве
            Console.WriteLine(new string('-', 150));
            }
            Console.Write("Для повтора операций с сортировкой массивов нажмите клавишу ENTER: ");
            Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine(new string('-', 150));
            goto Again;

        }
    }
}
