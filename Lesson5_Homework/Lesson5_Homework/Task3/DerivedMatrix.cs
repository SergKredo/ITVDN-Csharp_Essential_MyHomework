using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DerivedMatrix : MyMatrix
    {
        Random random = new Random();
        int[,] derivedMatrix;
        
        public DerivedMatrix(int[,] derivedMatrix)
            : base(derivedMatrix)
        {
            this.derivedMatrix = derivedMatrix;
        }

        public void WriteMatrix(int strings, int columns, int k)
        {
            int stringsNew = random.Next(1, strings);
            int columnsNew = random.Next(1, columns);
            //derivedMatrix = new int[stringsNew, columnsNew];
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(" - DerivedMatrix {0}: [{1}, {2}]", k, stringsNew, columnsNew);
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < stringsNew; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < columnsNew; j++)
                {
                    Console.Write(derivedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();
        }
    }
}
