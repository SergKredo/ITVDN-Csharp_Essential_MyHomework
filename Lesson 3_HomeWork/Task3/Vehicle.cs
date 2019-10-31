using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        string coordinates;
        double cost;
        double speed;
        string yearOfIssue;
        double height;
        int numberOfPassengers;
        string portOfRegistry;


        public string Coordinates
        {
            get;
        }
        public double Cost
        {
            get;
        }
        public double Speed
        {
            get;
        }
        public string YearOfIssue
        {
            get;
        }
        public double Height
        {
            get;
        }
        public int NumberOfPassengers
        {
            get;
        }
        public string PortOfRegistry
        {
            get;
        }
        public Vehicle(Car car, Ship ship, Plane plane)
        {
           
        }
        public Vehicle(string name)
        {
            
            this.Coordinates = "59,755831°, 35,617673°";
            
            this.Cost = 30000;
           
            this.Speed = 150;
           
            this.YearOfIssue = "1999";
        }
        public Vehicle(string nameOne, string nameTwo)
        {
            
            this.Coordinates = "53,755831°, 30,617673°";
            
            this.Cost = 20000000;
            
            this.Speed = 500;
            
            this.YearOfIssue = "1985";
            
            this.Height = 6000;
            
            this.NumberOfPassengers = 150;
        }
        public Vehicle(string nameOne, string nameTwo, string nameThree)
        {
           
            this.Coordinates = "55,755831°, 37,617673°";
            
            this.Cost = 30000000;
            
            this.Speed = 30;
           
            this.YearOfIssue = "1965";
           
            this.NumberOfPassengers = 300;
           
            this.PortOfRegistry = "Одесса";
        }
        public Vehicle()
        {
     
        }

        public void MetodOne()
        {
            Car car = new Car("car");
            car.Method();
        }
        public void MetodTwo()
        {
            Plane plane = new Plane("plane");
            plane.Method();
        }
        public void MetodThree()
        {
            Ship ship = new Ship("ship");
            ship.Method();
        }

    }
}

