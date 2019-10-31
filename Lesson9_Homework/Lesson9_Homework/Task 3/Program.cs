using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
        /*Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
    среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
    Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.*/
    class Program
    {
        public delegate int DelegateMassive(NumberDelegate[] MassiveDelegate);  // Объявление класса-делегата с именем DelegateMassive, сообщенным с методом, который принимает в качестве параметров одномерный массив делегатов типа NumberDelegate и возвращает целочисленное значение
        public delegate int NumberDelegate(int a);                              // Объявление класса-делегата с именем NumberDelegate, сообщенного с методом, который принимает целочисленный параметр типа int и возвращает целочисленное значение
        static void Main(string[] args)
        {
            Console.WriteLine("An array of delegates using an array of anonymous methods".ToUpper());
            Console.WriteLine(new string('-', 150));
            int order = 1;                                                     // Переменная определяет порядок выведенных в консоли массивов
            while (true)                                                       // Условная конструкция - определяет циклический возврат для массивов делегатов
            { 
                Random random = new Random();                                  // Экземпляр класса (генератор псевдослучайных чисел) 
                NumberDelegate[] delegateMassive = new NumberDelegate[random.Next(1,20)];  //Создание масива классов-делегатов типа NumberDelegate с псевдослучайным присвоением размера массива
                DelegateMassive @delegate = delegate (NumberDelegate[] massive) // Создание экземпляра класса-делегата типа DelegateMassive с присвоением ему анонимного метода, который принимает массив делегатов типа NumberDelegate и возвращает среднеарифметическое значение сообщенных анонимных методов массива NumberDelegate
                {
                int sum = 0;                                                    // Переменная, которая суммирует все целочисленные значения, которые возвращают сообщенные анонимные методы массива делегатов типа NumberDelegate 
                    Console.Write("{1} - massive [{0}]: (".ToUpper(), massive.Length, order);
            for (int i = 0; i < massive.Length; i++)                           // Циклическая конструкция для инициализации элементов массива
            {
                massive[i] = new NumberDelegate(delegate (int b) { return b; });  // Присвоение элементу массива делегатов типа NumberDelegate целочисленного значения, которые возвращают анонимные методы 
                int number = random.Next(0, 1000);                             // Присвоение целочисленной переменной псевдослучайного числа от нуля до 100
                int numberTwo = massive[i].Invoke(number);
                Console.Write(numberTwo);
                if (i != massive.Length - 1)
                {
                    Console.Write(" + ");
                }
                sum += numberTwo;                                              // Сумма всех целочисленных значений, которые возвращают анонимные методы в элементах массива типа NumberDelegate
                    }
                Console.Write(")/{0} = ", massive.Length);
                return sum / massive.Length;                                   // Возвращение среднеарифметического значения всех возвращенных целочисленных значений от анонимных методов массива NumberDelegate
                };
                Console.Write(@delegate.Invoke(delegateMassive)+"\n");         // Вывод в консоли параметров класса-делегата типа DelegateMassive
                Console.ReadKey();
                ++order;
            }
        }
    }
}
