using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship: Vehicle
    {
        int numberOfPassengers;
        string portOfRegistry;
        string coordinates;
        double cost;
        double speed;
        string yearOfIssue;
        static string nameOne, nameTwo;
        static string nameThree = "корабля";
        public Ship(): base()
        {

        }
        public Ship(string nameThree) : base(nameOne, nameTwo, nameThree)
        {
            this.coordinates = Coordinates;
            this.cost = Cost;
            this.speed = Speed;
            this.yearOfIssue = YearOfIssue;
            this.portOfRegistry = PortOfRegistry;
            this.numberOfPassengers = NumberOfPassengers;
        }

        public void Method()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Основные характеристики {4}:\nкоординаты - {0};\nстоимость - {1};\nскорость - {2};\nгод выпуска - {3};\nпорт регистрации - {5};\nколичество пассажиров - {6};", coordinates, cost, speed, yearOfIssue, nameTwo, portOfRegistry, numberOfPassengers);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
