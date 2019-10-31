using System;

namespace AdditionalTask
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте структуру с именем - Notebook.
Поля структуры: модель, производитель, цена.
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода
содержимого полей на экран.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Характеристики товара:");
            Notebook notebook = new Notebook("Jiayu G5 Advanced", "Jiayu", 5653.8d);
            notebook.Show();
            Console.ReadKey();
        }
    }
}
