using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class ExtensionMethod
    {
        public static void SortMassiveLessToBigger(this int[] number)  // Расширяющий метод сортировки массива
        {
            Array.Sort(number);         // Метод класса Array для сортировки массива с наименьшего до наибольшего значения
            for (int i = 0; i < number.Length; i++)   // Вывод в консоли элементов массива после применения метода сортировки значений элементов массива
            {
                Console.Write(number[i]+"; ");
            }
            Console.WriteLine();
        }
        public static void SortMassiveBiggerToLess(this int[] number)   // Расширяющий метод сортировки массива
        {
            Array.Sort(number);         
            Array.Reverse(number);                    // Метод класса Array для сортировки массива с наибольшего до наименьшего значения
            for (int i = 0; i < number.Length; i++)   // Вывод в консоли элементов массива после применения метода сортировки значений элементов массива
            {
                Console.Write(number[i] + "; ");
            }
            Console.WriteLine();
        }
    }
}
