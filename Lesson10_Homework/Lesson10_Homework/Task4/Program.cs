using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray().*/
    static class GetArrayClass
    {
        static object[] newMassive; // Объявление одномерного массива статических объектов

        public static object[] GetArray<T>(this MyList<T> list)  // Создание расширяющего метода к экземпляру типа MyList<T>. Метод выводит список элементов всех определенных объектов
        {
            newMassive = list.DefinitionObjects();
            for (int i = 0; i < newMassive.Length; i++)
            {
                Console.Write(" [{0}] - " + newMassive[i].GetType() + ": " + newMassive[i] + ";\n", i);
            }
            return null;
        }

        public static object[] GetArray<T>(this MyList<T> list, object[] variable)  // Создание расширяющего метода к экземпляру типа MyList<T>. Метод принимает массив элементов, которые мы хотели бы добавить в первоначальный список. Метод также выводит список всех элементов определенных объектов (основного массива и добавленного)
        {
            object[] newMassive = list.Add(variable);
            for (int i = 0; i < newMassive.Length; i++)
            {
                if (i >= newMassive.Length - variable.Length && i < newMassive.Length + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" [{0}] - " + newMassive[i].GetType() + ": " + newMassive[i] + ";\n", i);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    newMassive[i] = GetArrayClass.newMassive[i];
                    Console.Write(" [{0}] - " + newMassive[i].GetType() + ": " + newMassive[i] + ";\n", i);
                }
            }
            return null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Console.Write("- All elements of the initial array: \n".ToUpper());
            myList.GetArray();  // Вызов на экземпляре расширяющего метода

            Console.WriteLine(new string('-', 70));
            Console.Write("\n" + new string(' ', 10) + "- Add element to previous massive: ".ToUpper());
            object[] variable = { "hello", 'r', 546664565m, false, (short)255 };  // Определение дополнительного массива объектов
            myList.GetArray(variable);  // Вызов на экземпляре расширяющего метода, который принимает дополнительный массив элементов объектов

            Console.ReadKey();
        }
    }
}
