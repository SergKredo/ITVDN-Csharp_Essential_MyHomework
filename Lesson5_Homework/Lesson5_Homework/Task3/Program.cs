using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{ /*Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера
    с возможностью изменения числа строк и столбцов.
    Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пожалуйста количество строк в матрице: ");
            int strings = int.Parse(Console.ReadLine());
            Console.Write("Введите пожалуйста количество столбцов в матрице: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] baseMatrix = new int[strings, columns];
            
            MyMatrix matrix = new DerivedMatrix(baseMatrix);
            matrix.WriteMatrix(strings, columns);

            for(int i = 1; true; i++)
            {
            (matrix as DerivedMatrix).WriteMatrix(strings, columns, i);
            }
            

            
        }
    }
}
