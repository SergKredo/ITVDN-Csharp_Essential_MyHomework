using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Task3;                  // 1-й способ: объявление пространства имен Task3 с базовым классом через директиву using



namespace Task4
{
    extern alias DerClass;     // 2-й способ: объявление пространства имен Task3 с базовым классом через формирование alias для данного пространства имен 
    class Derived : DerClass.Task3.Base   // Наследование от базового класса Base для внешней сборки (пространства имен Task3)
    {
        public Derived()  // Конструктор производного класса по умолчанию
        {
            Console.WriteLine("Assembly: {0}", this.GetType().Namespace);   // Выводит в консоли текущее название пространства имен
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived derivedInstance = new Derived();  // Создание экземпляра производного класса
            derivedInstance.BaseMethod();   // На созданном экземпляре производного класса вызов метода базового класса
            Console.ReadKey();
        }
    }
}
