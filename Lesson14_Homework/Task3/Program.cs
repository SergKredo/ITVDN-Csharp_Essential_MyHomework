﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Task3
{
    /*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте коллекцию MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении
возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>.
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления элемента, индексатор для получения значения элемента по указанному индексу и свойство
только для чтения для получения общего количества элементов. Реализуйте возможность перебора
элементов коллекции в цикле foreach.*/
    class Program
    {
        class MyDictionary<TKey, TValue>  // Класса Generic с указателем типа T
        {
            // Поля класса
            int count = 0;   // Целочисленное поле, которое определяет общее количество элементов массива
            public object[] dictionary;
            TKey[] massiveTKey;   // Объявление начального одномерного массив с указателем типа TKey данного класса 
            TValue[] massiveTValue;   // Объявление начального одномерного массив с указателем типа TKey данного класса
            public TKey[] massiveAddElementTKey;   // Объявление одномерного массива с указателем типа Т данного класса, который имеет большую длину массива на один элемент
            public TValue[] massiveAddElementTValue;   // Объявление одномерного массива с указателем типа Т данного класса, который имеет большую длину массива на один элемент
            public IEnumerable<TKey> CurrentTKey { get; }    // Свойство типа IEnumerable для TKey
            public IEnumerable<TValue> CurrentTValue { get; }    // Свойство типа IEnumerable для TValue
            int countCollection = 0;
            public IEnumerable CurrentDictionary { get; }

            // Конструктор класса MyList
            public MyDictionary()
            {
                massiveTKey = new TKey[0];
                massiveTValue = new TValue[0];
                this.CurrentTKey = GetCollectionTKey();   // Присвоение свойству адреса возврата метода GetCollectionTKey()
                this.CurrentTValue = GetCollectionTValue();   // Присвоение свойству адреса возврата метода GetCollectionTValue()
                this.CurrentDictionary = GetCollectionDictionary();
            }

            //Cвойство только для чтения для получения общего количества элементов
            public int Count
            {
                get
                {
                    count = massiveAddElementTKey.Length;
                    return count;
                }
            }

            // Создание метода для добавления новых элементов key и value к данной коллекции. Метод принимает в качестве параметра новое значение элемента key и value
            public void Add(TKey paramKey, TValue paramValue)
            {
                massiveAddElementTKey = new TKey[massiveTKey.Length + 1];
                massiveAddElementTValue = new TValue[massiveTValue.Length + 1];
                for (int i = 0; i < massiveAddElementTKey.Length; i++)
                {
                    if (i < massiveAddElementTKey.Length - 1 && massiveTKey.Length != 0)
                    {
                        massiveAddElementTKey[i] = massiveTKey[i];
                        massiveAddElementTValue[i] = massiveTValue[i];
                    }
                    else
                    {
                        massiveAddElementTKey[i] = paramKey;
                        massiveTKey = massiveAddElementTKey;
                        massiveAddElementTValue[i] = paramValue;
                        massiveTValue = massiveAddElementTValue;
                    }
                }
            }

            // Создание индексатора через оператор foreach для получения значения элемента по указанному индексу
            public object this[int index]
            {
                get
                {
                    object elementCollection = null;
                    foreach (object element in this.CurrentDictionary)
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


            // Создание индексатора через оператор foreach для получения значения элемента по указанному индексу
            public object this[string index]
            {
                get
                {
                    object elementCollection = null;
                    foreach (object element in this.CurrentDictionary)
                    {
                        if (!(element.ToString().Contains(index)))
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

            // Метод, который формирует коллекцию ключей
            public IEnumerable<TKey> GetCollectionTKey()
            {
                foreach (TKey element in massiveAddElementTKey)
                {
                    yield return element;
                }
            }
            // Метод, который формирует коллекцию значений
            public IEnumerable<TValue> GetCollectionTValue()
            {
                foreach (TValue element in massiveAddElementTValue)
                {
                    yield return element;
                }
            }
            // Метод, который формирует коллекцию ключей и значений вместе
            public IEnumerable GetCollectionDictionary()
            {
                string words = null;
                dictionary = new object[massiveAddElementTKey.Length];
                for (int i = 0; i < massiveAddElementTKey.Length; i++)
                {
                    words = massiveAddElementTKey[i].ToString() + " - " + massiveAddElementTValue[i].ToString();
                    dictionary[i] = words;
                }
                foreach (object element in dictionary)
                {
                    yield return element;
                }

            }

        }

        static void Main(string[] args)
        {
            Random random = new Random();  // Экземпляр класса псевдослучайных чисел
            MyDictionary<string, string> myCollection = new MyDictionary<string, string>();  // Создание экземпляра generic класса формируюшего коллекцию словаря
            int count = 0;
            while (true)
            {
                Again:
                switch (count)
                {
                    case 0:
                        {
                            myCollection.Add("hello", "привет");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 1:
                        {
                            myCollection.Add("Welcome", "Добро пожаловать");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 2:
                        {
                            myCollection.Add("World", "Мир");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 3:
                        {
                            myCollection.Add("Bread", "Хлеб");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 4:
                        {
                            myCollection.Add("Spring", "Весна");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 5:
                        {
                            myCollection.Add("Table", "Стол");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 6:
                        {
                            myCollection.Add("Shame", "Стыд");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 7:
                        {
                            myCollection.Add("Moon", "Луна");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 8:
                        {
                            myCollection.Add("Star", "Звезда");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    case 9:
                        {
                            myCollection.Add("Sky", "Небо");          // Добавление нового элемента в коллекцию
                            break;
                        }
                    default:
                        {
                            count = 0;
                            goto Again;
                        }
                }
                int countTwo = 0;
                foreach (string dictionary in myCollection.CurrentDictionary)      // Поочередное присвоение переменной element всех возможных значений коллекции
                {
                    Console.WriteLine("index[{0}]: " + dictionary, countTwo++);       // Поочередный вывод в консоли элементов коллекции
                    if (myCollection.Count == countTwo)
                    {
                        Console.WriteLine(new string('-', 50));
                        Thread.Sleep(1000);                          // Остановка первичного потока на 1 секунду
                        int index = random.Next(0, myCollection.Count);
                        Console.WriteLine("Item by index[{0}] - " + myCollection[index], index);      // Вывод в консоли елемента коллекции соответствующего значению индексатора коллекции
                        int indexTwo = random.Next(0, myCollection.Count);
                        string indexword = null;
                        if (indexTwo % 2 == 0)
                        {
                            indexword = myCollection.massiveAddElementTValue[indexTwo];   // Индексатор по значению
                        }
                        else
                        {
                            indexword = myCollection.massiveAddElementTKey[indexTwo];     // Индексатор по ключу
                        }
                        Console.WriteLine("Item by index[{0}] - " + myCollection[indexword], indexword);      // Вывод в консоли елемента коллекции соответствующего значению индексатора коллекции


                        Console.WriteLine("Count all elements collection: " + myCollection.Count);    // Вывод в консоли значения, соответствующего общему количеству всех элементов в коллекции
                        Thread.Sleep(3000);
                        break;                                            // Прерывание цикла foreach
                    }
                    Thread.Sleep(100);
                }
                count++;
                Console.WriteLine(new string('*', 50));                      // Строка из штрихов размером 50 единиц
                Console.WriteLine(new string('*', 50));
                
            }
        }
    }
}
