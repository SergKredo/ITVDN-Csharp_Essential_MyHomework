using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            MatrixTwo matrixTwo;
            Console.SetWindowSize(100, 42);
            for (int i = 0; i < 33; i++)
            {
                matrixTwo = new MatrixTwo(i*3);
                Thread.Sleep(80);
                new Thread(matrixTwo.MyMethod).Start();
                Thread.Sleep(200);

            }

            Console.ReadKey();
        }
    }
}
