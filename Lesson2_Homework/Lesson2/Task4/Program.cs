using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
        /*Используя Visual Studio, создайте проект по шаблону Console Application
         Требуется:
    Создать класс Invoice.
    В теле класса создать три поля int account, string customer, string provider, которые должны
    быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
    дальнейшего изменения.
    В теле класса создать два закрытых поля string article, int quantity
    Создать метод расчета стоимости заказа с НДС и без НДС.
    Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The invoice with the purchase of the goods:");
            Console.Write("Account: ");
            int account = Convert.ToInt32(Console.ReadLine());
            Console.Write("Customer: ");
            string customer = Console.ReadLine();
            Console.Write("Provider: ");
            string provider = Console.ReadLine();
            Console.Write("Article: ");
            string article = Console.ReadLine();
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(new string('-', 100));
            Invoice invoice = new Invoice(account, customer, provider, article, quantity, cost);
            invoice.CalculateNDS();
            Console.WriteLine(new string('-', 100));

            Console.ReadKey();
        }
    }
}
