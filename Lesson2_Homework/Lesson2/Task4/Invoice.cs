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
    class Invoice
    {
        int account;
        string customer;
        string provider;
        string article;
        int quantity;
        double cost;
        public Invoice(int account, string customer, string provider, string article, int quantity, double cost)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
            this.cost = cost;
        }
        public void CalculateNDS()
        {
            Console.WriteLine("Стоимость {0} количеством {1} штук без учета НДС равно: {2} гривен.", article, quantity, cost*quantity);
            Console.WriteLine("Стоимость {0} количеством {1} штук с учетом НДС равно: {2} гривен.", article, quantity, (cost + (cost*0.2))* quantity);
        }
    }
}
