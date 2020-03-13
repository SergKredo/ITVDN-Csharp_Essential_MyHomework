using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
namespace Task2
{
    /*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования
ее экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
foreach.*/
    class Program
    {
        class MyLisit<T>  // Класса Generic с указателем типа T
        {
            // Поля класса
            int count = 0;   // Целочисленное поле, которое определяет общее количество элементов массива
            T[] massive;   // Объявление начального одномерного массив с указателем типа T данного класса 
            public T[] massiveAddElement;   // Объявление одномерного массива с указателем типа Т данного класса, который имеет большую длину массива на один элемент
            public IEnumerable<T> Current { get; }    // Свойство типа IEnumerable
            int countCollection = 0;
            
            // Конструктор класса MyList
            public MyLisit()                
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

        static void Main(string[] args)
        {
            Random random = new Random();  // Экземпляр класса псевдослучайных чисел
            MyLisit<double> myCollection = new MyLisit<double>();  // Создание экземпляра generic класса формируюшего коллекцию

            // Бесконечный цикл while
            while (true)
            {
                myCollection.Add(random.NextDouble());          // Добавление нового элемента в коллекцию
                int i = 0;                                      // Счетчик итераций за один цикл
                foreach (double element in myCollection.Current)      // Поочередное присвоение переменной element всех возможных значений коллекции
                {
                    Console.WriteLine("index[{0}]: " + element, i++);       // Поочередный вывод в консоли элементов коллекции
                    if (myCollection.Count == i)
                    {
                        Console.WriteLine(new string('-', 50));
                        Thread.Sleep(1000);                          // Остановка первичного потока на 1 секунду
                        int index = random.Next(0, myCollection.Count);
                        Console.WriteLine("Item by index[{0}] - " + myCollection[index], index);      // Вывод в консоли елемента коллекции соответствующего значению индексатора коллекции
                        Console.WriteLine("Count all elements collection: " + myCollection.Count);    // Вывод в консоли значения, соответствующего общему количеству всех элементов в коллекции
                        Console.WriteLine(new string('-', 50));                      // Строка из штрихов размером 50 единиц
                        Console.WriteLine(new string('-', 50));
                        Thread.Sleep(1000);
                        break;                                            // Прерывание цикла foreach
                    }
                    Thread.Sleep(500);
                }

            }
        }
    }
}
