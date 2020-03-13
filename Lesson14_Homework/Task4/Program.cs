using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task4
{
    /*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод:
public static T[] GetArray<T>(this IEnumerable<T> list){…}
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray().*/

    class MyList<T>  // Класса Generic с указателем типа T
    {
        // Поля класса
        int count = 0;   // Целочисленное поле, которое определяет общее количество элементов массива
        T[] massive;   // Объявление начального одномерного массив с указателем типа T данного класса 
        public T[] massiveAddElement;   // Объявление одномерного массива с указателем типа Т данного класса, который имеет большую длину массива на один элемент
        public IEnumerable<T> Current { get; }    // Свойство типа IEnumerable
        int countCollection = 0;

        // Конструктор класса MyList
        public MyList()
        {
            massive = new T[0];
            this.Current = GetCollection();   // Присвоение свойству адреса возврата метода GetEnumerator()
        }

        //Cвойство только для чтения для получения общего количества элементов
        public int Count
        {
            get
            {
                count = massiveAddElement.Length;
                return count;
            }
        }

        // Создание метода для добавления нового элемента к данной коллекции. Метод принимает в качестве параметра новое значение элемента
        public void Add(T param)
        {
            massiveAddElement = new T[massive.Length + 1];
            for (int i = 0; i < massiveAddElement.Length; i++)
            {
                if (i < massiveAddElement.Length - 1 && massive.Length != 0)
                {
                    massiveAddElement[i] = massive[i];
                }
                else
                {
                    massiveAddElement[i] = param;
                    massive = massiveAddElement;
                }
            }
        }

        // Создание индексатора через оператор foreach для получения значения элемента по указанному индексу
        public T this[int index]
        {
            get
            {
                T elementCollection = default(T);
                foreach (T element in this.Current)
                {
                    if (index != countCollection++)
                    {
                        continue;
                    }
                    else
                    {
                        elementCollection = element;
                    }
                }
                countCollection = 0;             // Обнуление счетчика
                return elementCollection;
            }
        }

        // Метод, который формирует коллекцию
        public IEnumerable<T> GetCollection()
        {
            foreach (T element in massiveAddElement)
            {
                yield return element;
            }
        }

    }



    static class ExtentionMethod  // Статический класс для формирования расширяющего метода
    {
        public static T[] MyGetArray<T>(this IEnumerable<T> list, int count)   // Расширяющий метод. Метод выводит в консоли значения элементов коллекции.
        {
            T[] elementCollection = new T[count];
            int countIndex = 0;
            foreach (T element in list)      // Поочередное присвоение переменной element всех возможных значений коллекции
            {
                Console.WriteLine("index[{0}]: " + element, countIndex);       // Поочередный вывод в консоли элементов коллекции
                elementCollection[countIndex++] = element;
                Thread.Sleep(300);
            }
            return elementCollection;
        }
    }


    class Program
    {
        static void Main()
        {
            Random random = new Random();  // Экземпляр класса псевдослучайных чисел
            MyList<double> myCollection = new MyList<double>();  // Создание экземпляра generic класса формируюшего коллекцию
            while (true)
            {
                myCollection.Add(random.NextDouble());
                int count = myCollection.Count;
                myCollection.Current.MyGetArray<double>(count);   // Вызов на экземпляре коллекции расширяющего метода
                Console.WriteLine(new string('-', 50));
                Thread.Sleep(1000);
            }
        }
    }
}
