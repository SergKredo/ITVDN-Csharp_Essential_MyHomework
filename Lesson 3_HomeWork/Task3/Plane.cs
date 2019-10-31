using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Plane: Vehicle
    {
    string coordinates;
    double cost;
    double speed;
    string yearOfIssue;
    double height;
    int numberOfPassengers;
    static string nameOne;
    static string nameTwo = "самолета";
    public Plane(string nameTwo) : base(nameOne, nameTwo)
    {
        this.coordinates = Coordinates;
        this.cost = Cost;
        this.speed = Speed;
        this.yearOfIssue = YearOfIssue;
        this.height = Height;
        this.numberOfPassengers = NumberOfPassengers;
    }
    public Plane() : base()
    {

    }
    public void Method()
    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Основные характеристики {4}:\nкоординаты - {0};\nстоимость - {1};\nскорость - {2};\nгод выпуска - {3};\nвысота - {5};\nколичество пассажиров - {6};", coordinates, cost, speed, yearOfIssue, nameTwo, height, numberOfPassengers);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
}
