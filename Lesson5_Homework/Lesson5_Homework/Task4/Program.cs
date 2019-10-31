using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
        /*Задание 4
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Article, содержащий следующие закрытые поля:
    • название товара;
    • название магазина, в котором продается товар;
    • стоимость товара в гривнах.
    Создать класс Store, содержащий закрытый массив элементов типа Article.
    Обеспечить следующие возможности:
    • вывод информации о товаре по номеру с помощью индекса;
    • вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров
    нет, выдать соответствующее сообщение;
    Написать программу, вывода на экран информацию о товаре.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] massive = new string[10];               // Создание массива строковых значений
            Article instance = new Article(massive);         // Создание экземпляра класса Article, с входящим формальным параметром в виде строкового массива "massive"
            Article[] instanceMassive = new Article[10];     // Создание массива экземпляров класса Article
            for (int i = 0; i < instanceMassive.Length; i++)  
            {
                instanceMassive[i] = instance;               // Инициализация элементов массива Article переменной "instance"
            }

            Store store = new Store(instanceMassive, massive);   // Создание экземпляра производного класса Store и передача ему параметров в виде элементов экземпляров массива Article и строкового массива

            Console.WriteLine(new string('-', 70));              // Создание штрихпунктирной линии в консоли
            for (int i = 0; i < store.ProductName.Length; i++)   
            {
                Console.WriteLine(store[i]);                     // Вывод в консоли значений всех элементов массива экземпляров класса Store, используя индексирование экземпляров класса
            }
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(store[8]);                         // Вывод в консоли значения конкретного элемента массива экземпляра класса Store, используя индексирование экземпляров класса

            Console.WriteLine(new string('-', 70));
            Console.WriteLine(store["table"]);                   // Вывод в консоли значения конкретного элемента массива экземпляра класса Store с входящим строковым параметром, используя индексирование экземпляров класса
            Console.WriteLine(new string('-', 70));

            Console.ReadKey();                             
            
            
        }
    }
}
