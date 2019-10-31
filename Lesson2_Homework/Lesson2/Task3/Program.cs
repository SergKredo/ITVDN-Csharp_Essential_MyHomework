using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
        /*Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Employee.
    В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
    инициализирует поля, соответствующие фамилии и имени сотрудника.
    Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
    сбор.
    Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
    оклад и налоговый сбор.*/
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, position;
            double experience;
            Console.WriteLine("Vvedite osnovnie dannie rabotnyka:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surname = Console.ReadLine();
            Console.Write("Position (Junior employee, Middle employee, Senior employee): ");
            position = Console.ReadLine();
            Console.Write("Experience: ");
            experience = Convert.ToDouble(Console.ReadLine());

            Employee employee = new Employee(name, surname, position, experience);
            employee.InformationOutput();

            Console.ReadKey();
            

        }
    }
}
