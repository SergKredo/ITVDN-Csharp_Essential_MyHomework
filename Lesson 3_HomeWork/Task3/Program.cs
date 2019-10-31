using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
        /*Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Vehicle.
    В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
    выпуска).
    Создайте 3 производных класса Plane, Саг и Ship.
    Для класса Plane должна быть определена высота и количество пассажиров.
    Для класса Ship — количество пассажиров и порт приписки.
    Написать программу, которая выводит на экран информацию о каждом средстве передвижения.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Средства передвижения: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Введите пожалуйста основные характеристики 3-х\nтранспортных средств передвижения");

            Vehicle objects = new Vehicle(new Car(), new Ship(), new Plane());  //Экземпляр класса (объект)

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Машина:");
            objects.MetodOne();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Самолет:");
            objects.MetodTwo();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Корабль:");
            objects.MetodThree();
            Console.WriteLine(new string('-', 30));
            

            Console.ReadKey();
        }
    }
}
