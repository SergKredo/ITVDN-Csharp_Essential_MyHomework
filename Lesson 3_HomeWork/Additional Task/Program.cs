using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
        /*Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создайте класс Printer.
    В теле класса создайте метод void Print(string value), который выводит на экран значение
    аргумента.
    Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
    соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
    выводились разными цветами.
    Обязательно используйте приведение типов.*/
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new DerivedClass3();    // Создание экземпляра класса
            print.Print("Human with a gray Tshirt");
            Console.WriteLine("id instance: "+print.GetHashCode()+"\n");

            (print as DerivedClass1).Print("Human with a cyan Tshirt");
            Console.WriteLine("id instance: " + (print as DerivedClass1).GetHashCode() + "\n");

            (print as DerivedClass2).Print("Human with a dark red Tshirt");
            Console.WriteLine("id instance: " + (print as DerivedClass2).GetHashCode() + "\n");

            (print as DerivedClass3).Print("Human with a green Tshirt");
            Console.WriteLine("id instance: " + (print as DerivedClass3).GetHashCode() + "\n");

            Console.ReadKey();
        }
    }
}
