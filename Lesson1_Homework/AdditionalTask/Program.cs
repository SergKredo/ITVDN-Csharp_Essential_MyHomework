using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс с именем Address.
В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого
поля, создать свойство с двумя методами доступа.
Создать экземпляр класса Address.
В поля экземпляра записать информацию о почтовом адресе.
Выведите на экран значения полей, описывающих адрес.*/

    class Address
    {
        private string headline = "Address of the client in the bank:";
        private string index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public string Headline
        {
            get
            {
                return headline;
            }
        }
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        public int House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        public int Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
        public void ConvertsToUpperCase()
        {
            Console.WriteLine(Headline.ToUpper());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address()
            {
                Index = "03045",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Prospect Pobedy",
                House = 29,
                Apartment = 45
            };
            Console.WriteLine(new string('-', 34));
            address.ConvertsToUpperCase();
            Console.WriteLine("Index: {0}", address.Index);
            Console.WriteLine("Country: {0}", address.Country);
            Console.WriteLine("City: {0}", address.City);
            Console.WriteLine("Street: {0}", address.Street);
            Console.WriteLine("House: {0}", address.House);
            Console.WriteLine("Apartment: {0}", address.Apartment);
            Console.WriteLine(new string('-', 34));

            Console.ReadKey();

        }
    }
}
