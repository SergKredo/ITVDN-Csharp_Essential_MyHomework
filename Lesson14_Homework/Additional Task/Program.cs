using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Additional_Task
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает коллекцию
всех четных чисел массива. Для формирования коллекции используйте оператор yield.*/
    class Program
    {
        // Класс, который формирует коллекцию
        class Collection
        {
            int[] mycollection;  // Целочисленный одномерный массив
            Random randomNumber;  // Объявление экземпляра класса псевдослучайных чисел
            public IEnumerable Current { get; }    // Свойство типа IEnumerable
            public Collection()                     // Конструктор класса Collection
            {                                       // Инициализация элементов массива
                mycollection = new int[100];
                randomNumber = new Random();
                for (int i = 0; i < mycollection.Length; i++)
                {
                    mycollection[i] = randomNumber.Next(0, (int)(TimeSpan.TicksPerMillisecond));
                }
                this.Current = this.MyCollection(mycollection);  // Присвоение свойству адреса возврата метода MyCollection
            }

            // Метод, который формирует коллекцию всех четных чисел передаваемого ему массива
            IEnumerable MyCollection(int[] massive)
            {
                foreach (int element in mycollection)
                {
                    if (element % 2 != 0)
                    {
                        continue;
                    }
                    yield return element;   // Оператор yield, который формирует итератор. Оператор yield return используется для возврата каждого элемента по одному.
                }
            }
        }

        static void Main(string[] args)
        {
            Collection collection = new Collection();  // Создание коллекции
            while (true)
            {
                foreach (int element in collection.Current)
                {
                    Console.WriteLine(element);   // Итеррированный вывод в консоли значений элементов коллекции
                    Thread.Sleep(500);
                }
            }

        }
    }
}
