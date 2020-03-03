using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Additional_Task
{
        /*Задание 1
    Используя Visual Studio 2010, создайте проект по шаблону Console Application.
    Напишите программу, в которой метод будет вызываться рекурсивною.
    Каждый новый вызов метода выполняется в отдельном потоке.*/
    class Program
    {
        public static void MyMethod()
        {
            int idThread = Thread.CurrentThread.GetHashCode();
            Console.WriteLine("Thread - {0}", idThread);
            Thread.Sleep(100);
            Main();            // Рекурсия метода Main
        }
        static void Main()
        {
            Thread thread = new Thread(MyMethod);
            thread.Start();

        }
    }
}
