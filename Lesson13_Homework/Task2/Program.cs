using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    /*Задание 1
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой
цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый,
остальные символы темно-зеленые. Во время падения цепочки, на каждом шаге, все символы меняют
свое значение. Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. Смотрите ниже
снимок экрана, представленный как образец.*/
    class Program
    {

        static void Main()
        {
            Console.SetWindowSize(100, 43); //Устанавливаем размеры окна консоли
            Multitask multitask;
            
            for (int i = 0; i < 10000; i++)
            {
                multitask = new Multitask(i * 1000);
                new Thread(multitask.MyMethod).Start();
                
            }

            Console.ReadKey();
        }
    }
}
