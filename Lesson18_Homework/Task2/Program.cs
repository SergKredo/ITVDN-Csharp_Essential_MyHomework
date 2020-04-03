using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MyDictionaryCollection;  // Импорт в проект собственной dll библиотеки, созданной из урока 14, задания 3. 
                               //В данной dll библиотеке хранится пользовательский класс Dictionary<Tkey,TValue>


namespace Task2
{
        /*Задание 1
    Используя пример выполненного домашнего задания 3 из 15 урока, реализуйте возможность
    подключения вашего пространства имен и работы с MyDictionary<TKey,TValue> аналогично
    экземпляру класса Dictionary<TKey,TValue>.*/
    class Program
    {
        
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
