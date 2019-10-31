using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну.*/
    class Program
    {
        static void Main(string[] args)
        {
            Again:
            Console.Write("Выберите пожалуйста одну из валют (UAH, USD, EUR, RUB) для конвертации: ");
            string currency = Console.ReadLine();
            Console.Write("Введите пожалуйста количество денег для конвертации: ");
            double money = Convert.ToDouble(Console.ReadLine());
            Converter Money = new Converter(25.7812, 28.7647, 0.4028, currency, money);
            Money.ConvertToMoney(currency);
            Console.WriteLine("\n");
            goto Again;

            Console.ReadKey();

        }
    }
}
