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
Converter(double USD, double EUR, double RUB).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну.*/
    class Converter
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public string CURRENCY { get; set; }
        public double MONEY { get; set; }

            

        public Converter(double usd, double eur, double rub, string currency, double money)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
            this.CURRENCY = currency;
            this.MONEY = money;
        }
        public void ConvertToMoney(string currency)
        {
            if (currency == "UAH")
            {
                Console.WriteLine("UAH to USD: {0} USD", MONEY/USD);
                Console.WriteLine("UAH to EUR: {0} EUR", MONEY / EUR);
                Console.WriteLine("UAH to RUB: {0} RUB", MONEY / RUB);
            }
            if (currency == "RUB")
            {
                Console.WriteLine("RUB to USD: {0} USD", MONEY * (RUB/USD));
                Console.WriteLine("RUB to EUR: {0} EUR", MONEY * (RUB/EUR));
                Console.WriteLine("RUB to UAH: {0} UAH", MONEY * RUB);
            }
            if (currency == "EUR")
            {
                Console.WriteLine("EUR to USD: {0} USD", MONEY * (EUR/USD));
                Console.WriteLine("EUR to UAH: {0} UAH", MONEY * EUR);
                Console.WriteLine("EUR to RUB: {0} RUB", MONEY * (EUR/RUB));
            }
            if (currency == "USD")
            {
                Console.WriteLine("USD to UAH: {0} UAH", MONEY * USD);
                Console.WriteLine("USD to EUR: {0} EUR", MONEY * (USD/EUR));
                Console.WriteLine("USD to RUB: {0} RUB", MONEY * (USD/RUB));
            }
        }
    }
}
