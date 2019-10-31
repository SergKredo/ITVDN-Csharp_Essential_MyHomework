using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Store: Article    // Производный класс Store, наследованный от базового класса Article
    {
        private Article[] name;  // Объявление закрытого массива экземпляров класса Article
        public Article[] this[int index]  // Создание индексатора закрытого массива класса Articleс с входящим параметром целочисленного типа "index"
        {
            get                                   // Метод доступа в индексаторе для чтения в консоли
            {
                if (index >= 0 && index < 10)     // Условная конструкция при которой возможен вывод информации элементов массива класса Article в консоли
                {
                    Console.Write("Товар: " + name[index].ProductName[index] + "; ");
                    Console.Write("Магазин: " + name[index].NameOfShop[index] + "; ");
                    Console.Write("Стоимость: " + name[index].CostOfGoods[index] + " гривен;");
                    return null;
                }
                else                              // Условие при котором входящий параметр индексатора выходит за рамки индексов
                {
                    Console.WriteLine("Вы ввели неверный индекс!");
                    return null;                 // Возвращает пустое значение
                }
            }
        }

        public Article[] this[string index]  // Создание индексатора закрытого массива класса Articleс с входящим параметром строкового типа "index"
        {
            get
            {
                int sum = name.Length;       // Счетчик
                for (int i = 0; i < name.Length; i++)   // Циклическая конструкция для поиска значений массива класса Article  с использованием конкретного введенного строкового значения в индексе индексатора
                {
                    sum--;                              // Декремент постфиксная форма
                    if (index == name[i].ProductName[i])  // Условная конструкция на равенство индекса индексатора с именем продукта
                    {
                        Console.Write("Товар: " + name[i].ProductName[i] + "; ");
                        Console.Write("Магазин: " + name[i].NameOfShop[i] + "; ");
                        Console.Write("Стоимость: " + name[i].CostOfGoods[i] + " гривен;");
                        return null;
                    }
                    if (sum == 0)                      // Условная конструкция, которая реализуется, если значение индекса неравное ниодному названию имени продуктов
                    {
                        Console.WriteLine("Вы ввели неверное название товара!");
                        return null;
                    }
                }
                return null;
            }
        }

        public Store(Article[] name, string[] massivetwo)    // Пользовательский конструктор с двумя входящими формальными параметрами: массива экземпляров типа Array и строкового массива
            :base(massivetwo)                               //Наследование от базового конструктора родительского класса Article
        {
            this.name = name;                  // Присвоение закрытому массиву экземпляров класса Article значений входящего параметра от массива экземпляров типа Array, объявленных из класса Program метода Main
        }
    }
}
