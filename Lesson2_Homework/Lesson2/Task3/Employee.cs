using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Employee
    {
        string name;
        string surname;
        double salary = 750;
        double percent = 0.2;
        string position;
        double experience;
        double duty;

        public string Name
        {
            get;
        }
        public string Surname
        {
            get;
        }
        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
            
        }
        public double Percent
        {
            set
            {
                percent = value;
            }
            get
            {
                return percent;
            }
        }
        public string Position
        {
            get;
        }
        public double Experience
        {
            get;
        }
        public double Duty
        {
            set
            {
                duty = value;
            }
            get
            {
                return duty;
            }
        }
        public Employee(string name, string surname, string position, double experience)
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
            this.Experience = experience;
        }
        public double CalculateOfSalary()
        {
            if (Position == "Junior employee" && Experience <= 1)
            {
                Salary = (Salary + (Salary * 0.1));
                Duty = (Salary * Percent);
                Salary = Salary - Duty;
            }
            else if (Position == "Middle employee" && Experience > 1 && Experience <= 3)
            {
                Salary = Salary + (Salary * 0.5);
                Duty = (Salary * Percent);
                Salary = Salary - Duty;
            }
            else if (Position == "Senior employee" && Experience > 3)
            {
                Salary = Salary + (Salary * 1);
                Duty = (Salary * Percent);
                Salary = Salary - Duty;
            }
            return Salary;
        }
        public void InformationOutput()
        {
            Console.WriteLine("\nInformation about employee:");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Position: {0}", Position);
            Console.WriteLine("Experience: {0} years", Experience);
            Console.WriteLine("Salary: {0} USD", CalculateOfSalary());
            Console.WriteLine("Duty: {0} USD", Duty);
        }
    }
}
