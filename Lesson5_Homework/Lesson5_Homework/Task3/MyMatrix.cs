using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyMatrix
    {
        Random random = new Random();
        private int[,] parentMatrix;
        public MyMatrix(int[,] baseMatrix)
        {
            this.parentMatrix = baseMatrix;
            for (int i = 0; i < parentMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < parentMatrix.GetLength(1); j++)
                {
                    this.parentMatrix[i, j] = random.Next(0, 1000);

                }
            }
        }
        public void WriteMatrix(int strings, int columns)
        {   int stringsNew = strings;
            int columnsNew = columns;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(" - BaseMatrix: [{0}, {1}]", stringsNew, columnsNew);
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < parentMatrix.GetLength(0); i++)
            {
                Console.Write("   ");               
                for (int j = 0; j < parentMatrix.GetLength(1); j++)
                {
                Console.Write(parentMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 30));
        }
    }
}
