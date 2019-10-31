using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
        /*Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте класс MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
    использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
    Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
    добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
    свойство только для чтения для получения общего количества пар элементов.*/
    class Program
    {
        static void Main()
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("hello", "привет");
            myDictionary.Add("spring", "Весна");
            myDictionary.Add("house", "дом");
            

            Console.WriteLine(myDictionary[2]);
            Console.WriteLine("Количество заполненных пар элементов в списке равно: " + myDictionary.Count);

            MyDictionary<int, string> myDictionaryTwo = new MyDictionary<int, string>();
            myDictionaryTwo.Add(1, "один");
            myDictionaryTwo.Add(2, "два");
            myDictionaryTwo.Add(3, "три");
            myDictionaryTwo.Add(4, "четыри");
            myDictionaryTwo.Add(5, "пять");
            myDictionaryTwo.Add(6, "шесть");
            myDictionaryTwo.Add(7, "семь");
            Console.WriteLine(myDictionaryTwo[5]);
            Console.WriteLine("Количество заполненных пар элементов в списке равно: " + myDictionaryTwo.Count);

            MyDictionary<char, string> myDictionaryTHree = new MyDictionary<char, string>();
            myDictionaryTHree.Add('o', "один");
            myDictionaryTHree.Add('t', "два");
            myDictionaryTHree.Add('t', "три");
            myDictionaryTHree.Add('f', "четыри");
            
            Console.WriteLine(myDictionaryTHree[3]);
            Console.WriteLine("Количество заполненных пар элементов в списке равно: " + myDictionaryTHree.Count);

            MyDictionary<bool, string> myDictionaryFour = new MyDictionary<bool, string>();
            myDictionaryFour.Add(true, "верно");
            myDictionaryFour.Add(false, "ложь");
            myDictionaryFour.Add(false, "ложь");
            myDictionaryFour.Add(true, "верно");

            Console.WriteLine(myDictionaryFour[0]);
            Console.WriteLine("Количество заполненных пар элементов в списке равно: " + myDictionaryFour.Count);

            Console.ReadLine();
        }
    }
}
