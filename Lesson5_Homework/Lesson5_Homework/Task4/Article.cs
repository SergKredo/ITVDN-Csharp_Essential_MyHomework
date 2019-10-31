 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Article
    {
        private string[] productName = null;         // Строковой массив полей. Название продукта
        private string[] nameOfShop = null;          // Строковой массив полей. Название магазина
        private string[] costOfGoods = null;         // Строковой массив полей. Стоимость продукта

        public string[] ProductName { get; }   // Строковой массив свойств. Свойство только на чтение. Названия продуктов
        public string[] NameOfShop { get; }    // Строковой массив свойств. Свойство только на чтение. Названия магазинов
        public string[] CostOfGoods { get; }   // Строковой массив свойств. Свойство только на чтение. Названия стоимости продуктов
        public Article(string[] hello)          // Пользовательский конструктор с входящим параметром в виде строкового массива
        {
                                                // Инициализация элементов объявленных строковых массивов
            this.ProductName = hello; this.NameOfShop = new string[10]; this.CostOfGoods = new string[10];
            this.ProductName[0] = "vinchester"; this.NameOfShop[0] = "Rozetka"; this.CostOfGoods[0] = "1859.69";
            this.ProductName[1] = "disk"; this.NameOfShop[1] = "Neplaksa"; this.CostOfGoods[1] = "1253.74";
            this.ProductName[2] = "book"; this.NameOfShop[2] = "Aushan"; this.CostOfGoods[2] = "360";
            this.ProductName[3] = "pencil"; this.NameOfShop[3] = "Simens"; this.CostOfGoods[3] = "12.50";
            this.ProductName[4] = "table"; this.NameOfShop[4] = "Aushan"; this.CostOfGoods[4] = "3560";
            this.ProductName[5] = "plane"; this.NameOfShop[5] = "Antonov"; this.CostOfGoods[5] = "12000000";
            this.ProductName[6] = "laptop"; this.NameOfShop[6] = "Lenovo"; this.CostOfGoods[6] = "25346";
            this.ProductName[7] = "desktop"; this.NameOfShop[7] = "HP"; this.CostOfGoods[7] = "38000";
            this.ProductName[8] = "water"; this.NameOfShop[8] = "Polyana Kvasova"; this.CostOfGoods[8] = "22.35";
            this.ProductName[9] = "bread"; this.NameOfShop[9] = "KievHlib"; this.CostOfGoods[9] = "15.90";
        }
    }
}
