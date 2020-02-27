using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен
System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром,
должен включать метод добавления пар элементов, индексатор для получения значения элемента по
указанному индексу и свойство только для чтения для получения общего количества пар элементов.
     */

    class MyDictionary<TKey, TValue>
    {
        string key, value;
        Dictionary<TKey, TValue> valuePairs = new Dictionary<TKey, TValue>();
        object[][] matrix = new object[2][] { new object[10], new object[10]};
        public void Add(TKey key, TValue value)
        {
            valuePairs.Add(key, value);
            for (int i = 0; i < matrix[0].Length; i++)
                {
                if (matrix[0][i] == null)
                { 
                    matrix[0][i] = key;
                    break;
                }
                }
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[1][j] == null)
                {
                    matrix[1][j] = value;
                    break;
                }
            }
        }

        public string this[TKey key]
        {
            get
            {
                if (valuePairs.ContainsKey(key))
                {
                    return valuePairs[key].ToString();
                }
                else
                {
                    return "The key is not in the dictionary!";
                }
            }
        }
        public int Count()
        {
            return valuePairs.Count;
        }
        public string this[int index]
        {
            get
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    if (i == index)
                    {
                        key = (string)matrix[0][i];
                        value = (string)matrix[1][i];
                        break;
                    }
                }
                return key +"-"+ value;
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            Console.WriteLine("Translate:".ToUpper());
            Console.WriteLine(new string('-', 30));
            string exit = null;
            int i = 1;
            while (exit != "Exit")
            {
                Console.Write("Add the word{0}: ", i);
                string word = Console.ReadLine();
                Console.Write("Add a translation of the word{0}: ", i);
                string translationWord = Console.ReadLine();
                exit = Console.ReadLine();
                dictionary.Add(word, translationWord);
                i++;
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All words:".ToUpper());
            for (int k = 0; k < dictionary.Count(); k++)
            {
                Console.WriteLine(dictionary[k]);
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(dictionary["слово"]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            Console.Write("The number of word pairs: ".ToUpper()+ dictionary.Count());
            

            Console.ReadKey();

        }
    }
}
