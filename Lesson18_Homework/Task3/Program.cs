using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Задание 2
Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному
методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки.*/

    public class Base
    {
        /// <summary>
        /// Метод базового класса
        /// </summary>
        public void BaseMethod()   // Метод базового класса
        {
            Console.WriteLine("Assembly: {0}", new Base().GetType().Namespace);  // Выводит в консоли текущее название пространства имен
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
