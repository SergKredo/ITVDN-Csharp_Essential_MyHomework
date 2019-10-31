using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car: Vehicle
    {
        string coordinates;
        double cost;
        double speed;
        string yearOfIssue;
        static string name = "машины";
        
        public Car(string name): base(name)
        {
            this.coordinates = Coordinates;
            this.cost = Cost;
            this.speed = Speed;
            this.yearOfIssue = YearOfIssue;
        }
        public Car(): base()
        {
            
        }
        public void Method()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Основные характеристики {4}:\nкоординаты - {0};\nстоимость - {1};\nскорость - {2};\nгод выпуска - {3};", coordinates, cost, speed, yearOfIssue, name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
       
        
    }
}
