using System;

namespace Task2
{
    /*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта
назначения, номер поезда, время отправления.
Написать программу, выполняющую следующие действия:
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть
упорядочены по номерам поездов);
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
вывести соответствующее сообщение).*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Номера поездов выберутся случайно в пределах от 1 до ");
            int numberRandom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 70));
            string[] destination = new string[8];
            int[] numberTrain = new int[8];
            string[] dataTime = new string[8];

            Train train = new Train(destination, numberTrain, dataTime, numberRandom);
            train.ShowTrain();
            Console.WriteLine(new string('-', 70));
            Console.Write("Введите номер поезда, чтобы узнать интересующую Вас информацию: ");
            int numberTrainSimple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(train[numberTrainSimple]);

            Console.ReadKey();

        }
    }
}
