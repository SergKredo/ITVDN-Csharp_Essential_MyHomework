using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Multitask
    {
        int b = 0, c = 0, k = 0, t = 0, d = 100000, massiveLength = 10000;
        static readonly object things = new object(); //Объект синхронизации доступа к разделяемому ресурсу (объект блокировки)
        Random randomCursor; //Создание екземпляра класса Random
        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //Статическое строковое поле
        string[][] massive;
        int colonCursor;
        public Multitask(int par)
        {
            randomCursor = new Random();
            colonCursor = par;
        }
        private char GetChar()//Метод возвращающий 
        {
            return litters.ToCharArray()[randomCursor.Next(0, 35)]; //Возвращает оодно значение из строкового поля litters
        }
        public void MyMethod(object param)  // Методо отображения одной цепочки
        {
  
            int randomCursorInt;
            while (true)
            {
                randomCursorInt = randomCursor.Next(10, 150);
                //lock (things)
                {
                    massive = new string[massiveLength][];
                    for (k = 0; k < massive.Length; k++)
                    {
                        //lock (things)
                        {
                            if (k > massiveLength)
                            {
                                k = 0;
                            }
                            massive[k] = new string[100000];
                            
                            if (b < 100000)
                            {
                                //lock (things)
                                {
                                    for (int i = 0; i < massive[0].Length; i++)
                                    {
                                        b++;
                                        massive[k][i] = GetChar().ToString();
                                        
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(massive[k][i]);
                                        Console.WriteLine((massive[k][i]).ToString().PadLeft(randomCursorInt));
                                        //Thread.Sleep(200);
                                    }
                                }
                            }
                            else if (b >= 100000 && b < 5200000)
                            {
                                //lock (things)
                                {
                                    for (int i = 0; i < massive[0].Length; i++)
                                    {
                                        b++;
                                        massive[k][i] = GetChar().ToString();
                                        
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine((massive[k][i]).ToString().PadLeft(randomCursorInt));
                                        //Thread.Sleep(200);
                                    }
                                }
                            }
                            else
                            {
                                //lock (things)
                                {
                                    for (int i = 0; i < massive[0].Length; i++)
                                    {
                                        b++;
                                        if (b >= 5200000)
                                        {
                                            Console.Clear();
                                            //lock (things)
                                            if (!(--d < 0))
                                            {
                                                //d--;
                                                for (int f = d; f < massive[k].Length; f++)
                                                {
                                                    massive[k][f] = GetChar().ToString();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    
                                                    Console.WriteLine((massive[k][f]).ToString().PadLeft(randomCursorInt));
                                                    //Thread.Sleep(200);
                                                }
                                            }
                                            else
                                            {
                                                d = 100000;
                                            }
                                            {
                                            }
                                            b++;
                                            for (int p = 0; p < t - 1; p++)
                                            {
                                                Console.WriteLine();

                                            }
                                            for (int a = 0; a < d; a++)
                                            {
                                                massive[k][a] = GetChar().ToString();
                                                
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine((massive[k][a]).ToString().PadLeft(randomCursorInt));
                                                //Thread.Sleep(200);
                                            }
                                            t--;
                                            break;
                                        }
                                    }
                                }
                            }
                            //lock (things)
                            {
                                if (!(d == 0))
                                {
                                    if (b > 100000)
                                    {
                                        // Скорость цепочки сверху вниз
                                        //Thread.Sleep(1);
                                    }
                                    Console.Clear();
                                    ++t;
                                    for (int p = 0; p < t; p++)
                                    {
                                        
                                        Console.WriteLine();

                                    }
                                }
                                else
                                {
                                    k = 610000;
                                    break;
                                }

                            }

                            //Thread.Sleep(1);
                        }
                    }
                }
                    lock (things)
                {
                    if (d == 0 && k == 610000 && c++ <= 1000000)
                    {
                        d = 100000;
                        b = 100000;
                        t = 0;
                        Console.Clear();
                        //Thread.Sleep(1);
                        break;
                    }
                }
            }
            
        }
    }
}
