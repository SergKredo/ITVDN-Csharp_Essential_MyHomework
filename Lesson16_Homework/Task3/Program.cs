using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Задание 3
Создайте класс House c двумя полями и свойствами.
Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое
копирование соответственно. Реализуйте простой способ проверки.*/


    /*Интерфейс ICloneable поддерживает копирование, при котором создается новый экземпляр
класса с тем же значением, что и у существующего экземпляра. Реализовав интерфейс ICloneable, можно создать все условия для копирования объекта.
Интерфейс ICloneable содержит один член, Clone, предназначенный для поддержки
копирования помимо выполняемого с помощью метода MemberwiseClone.*/
    class House : ICloneable 
    {
        string city = "Kyiv";  // Закрытое строковое поле  - название города
        string address = "Chreshatik, 46";    // Закрытое строковое поле - адрес дома
        public string City   //Свойство определяет название города где расположен дом
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Address  // Свойство определяет название адреса дома
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public House()  //Конструктор по умолчанию (без входящих параметров)
        {

        }
        public House(string city, string address)  // Пользовательский конструктор с 2-мя входящими параметрами
        {
            this.city = city;
            this.address = address;
        }

        // Глубокое копирование - происходит с помощью создания нового єкземпляра класса House с входящими параметрами конструктора текущего экземпляра
        public object DeepClone()
        {
            // Клонирование с использованием конструктора.
            return new House(this.City, this.Address) as object;  
        }


        // Поверхностное копирование - при котором происходит не инстанцирование экземпляра объекат, а его клонирование. 
        public object Clone()
        {
            // Клонирование с использованием MemberwiseClone().

            // Преимущество клонирования с использованием MemberwiseClone() в том, что
            // при клонировании не вызывается конструктор, а клонирование происходит через
            // копирование дампа памяти - тела оригинала.
            return this.MemberwiseClone();
        }

        //Переопределение метода ToString базового класса Object
        public override string ToString()
        {
            return string.Format("city: {0}, address: {1}, id: {2}", this.city, this.address, this.GetHashCode());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            House houseOne = new House();
            Console.WriteLine(houseOne);
            House houseTwo = houseOne.DeepClone() as House;
            Console.WriteLine(houseTwo);
            House houseThree = houseOne;
            Console.WriteLine(houseThree);
            Console.WriteLine(new string('-', 50));

            // Изменяем houseThree.City (при этом houseTwo.City не изменится)
            houseThree.City = "Moscow";
            Console.WriteLine(houseOne);
            Console.WriteLine(houseTwo);
            Console.WriteLine(houseThree);

            Console.WriteLine(new string('*', 50));
            Console.WriteLine(houseThree);
            House houseFour = houseThree.Clone() as House;
            Console.WriteLine(houseFour);
            House houseFive = houseThree;
            Console.WriteLine(houseFive);
            Console.WriteLine(new string('-', 50));

            houseFive.City = "Harkiv";
            Console.WriteLine(houseThree);
            Console.WriteLine(houseFour);
            Console.WriteLine(houseFive);
            Console.ReadKey();

        }
    }
}
