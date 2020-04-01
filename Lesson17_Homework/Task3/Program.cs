using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application
Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и
выведите на экран его содержание.*/

    class MyDictionary   // Объявление класса MyDictionary, для формирования коллекции англо-русских слов
    {
        public static IEnumerable CollectionGenerator()    // Статический метод, который формирует коллекцию слов
        {
            // Оператор yield, который формирует итератор. Оператор yield return new {......} используется для возврата каждого элемента анонимного типа по одному.
            yield return new { Key = "apple", Value = "яблоко" };
            yield return new { Key = "table", Value = "стол" };
            yield return new { Key = "world", Value = "мир" };
            yield return new { Key = "pen", Value = "ручка" };
            yield return new { Key = "telephone", Value = "телефон" };
            yield return new { Key = "laptop", Value = "ноутбук" };
            yield return new { Key = "water", Value = "вода" };
            yield return new { Key = "grass", Value = "трава" };
            yield return new { Key = "mouse", Value = "мыша" };
            yield return new { Key = "milk", Value = "молоко" };
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Язык LINQ. Выражение запроса.
            var query = from dynamic item in MyDictionary.CollectionGenerator()   // Использование динамического типа в объявлении переменной диапазона
                        orderby item.Key, item.Value
                        select item;

            Console.WriteLine(" Dictionary English-Russian Words".ToUpper());
            Console.WriteLine(" "+new string('-', 35));

            //Перебор всех элементов коллекции с помощью оператора foreach. Элементы коллекции извлекаются поочередно из коллекции и присваиваются переменной итерации item динамического типа для доступа к инкапсулированным свойствам анонимных элементов коллекции запроса
            foreach (dynamic item in query)
            {
                Console.WriteLine("  {0}:          \t{1}", item.Key, item.Value);
            }
            Console.WriteLine(" " + new string('-', 35));
            Console.ReadKey();

        }
    }
}
