using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
        /*Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3
    метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop()
    соответственно.
    Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
    Написать программу, которая выполняет проигрывание и запись.*/
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            ((IPlayable)player).Pause();   // Явное приведение экземпляра класса к базовому интерфейсу - 1-й способ
            (player as IPlayable).Stop();  // Явное приведение экземпляра класса к базовому интерфейсу - 2-й способ
            IPlayable playerone = (IPlayable)player; // Явное приведение экземпляра класса к базовому интерфейсу - 3-й способ
            playerone.Stop();
            Console.WriteLine();
            player.Record();
            ((IRecodable)player).Pause();
            (player as IRecodable).Stop();
            
            Console.ReadKey();

            

        }
    }
}
