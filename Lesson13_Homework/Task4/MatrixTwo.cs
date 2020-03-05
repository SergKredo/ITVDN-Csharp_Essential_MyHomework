using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task4
{
    class MatrixTwo
    {
        public static object key = new object();  //Объект синхронизации доступа к разделяемому ресурсу (объект блокировки)
        string literals = "QWERTYUIOPASDFGHJKLZXCVBNM123456789";
        Random random = new Random();    // Генератор псевдослучайных чисел
        string[] matrixOne;       // Объявление одномерной матрицы, отвечающей за количество ячеек-литералов в определенном столбце
        string[] matrixTwo;       // Объявление одномерной матрицы, отвечающей за количество ячеек-литералов в определенном столбце
        int numberColomn;      // Положение колонки
        int upColomn = 0;      // Позиция курсора по вертикали консоли
        int upColomnTwo = 0;
        public MatrixTwo(int par)   // Пользовательский конструктор класса Matrix
        {
            Console.CursorTop = upColomn;  // Положение курсора в консоли (происходит перемещение сверху-вниз)
            numberColomn = par;  // Присвоение числового значения, отвечающего за положение колоноки в консоли
        }
        public void MyMethod()   // Метод, который формирует одну цепочку литералов в столбце
        {
            int lengthOne = 0;  // Длина цепочки в столбце
            int lengthTwo = 0;  // Длина цепочки в столбце
            int indentThread = 0;  // Отступ первой цепочки от второй по вертикали в столбце
            bool right = true;     // Доступ процесса первой цепочки в консоли

            while (true)     // Бесконечный цикл
            {
                Thread.Sleep(random.Next(1, 10000));   // Поток останавливается на заданное время (в миллисекундах)
                matrixOne = new string[random.Next(3, 6)];            // Массив в потоке каждый раз формируется разного размера (в пределах от 3 до 6 элементов)
                matrixTwo = matrixOne;                                // Массив в потоке каждый раз формируется разного размера (в пределах от 3 до 6 элементов)
                indentThread = random.Next(10, 15);

                for (int k = 0; k <= 57; k++)  // Циклическое повторение итераций в пределах высоты консоли (происходит полный проход одной цепочки сверху вниз)
                {
                    lock (key)  //Блокирует блок кода, предназначен для контроля доступа к критической секции
                    {
                        if (right != false)
                        { 
                            for (int j = 0; j < (upColomn + 1) - matrixOne.Length; j++)  // Циклическая конструкция, которая затирает ячейки столбца в черный цвет. Затирание происходить пошагово сверху вниз после появления в консли полного выражения из литералов.
                            {
                                if (upColomn != 0 && upColomn >= matrixOne.Length)
                                {
                                    Console.CursorLeft = numberColomn;
                                    Console.CursorTop = j;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("█");
                                }
                                if (j + 1 >= (upColomn + 1) - matrixOne.Length)
                                {
                                    upColomn = j + 1;
                                }
                            }
                        }

                        for (int j = 0; j < (upColomnTwo + 1) - matrixTwo.Length; j++)  // Циклическая конструкция, которая затирает ячейки столбца в черный цвет. Затирание происходить пошагово сверху вниз после появления в консли полного выражения из литералов.
                        {
                            if (upColomnTwo != 0 && upColomnTwo >= matrixTwo.Length)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = j;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("█");
                            }
                            if (j + 1 >= (upColomnTwo + 1) - matrixTwo.Length)
                            {
                                upColomnTwo = j + 1;
                            }
                        }
                        lengthOne = 0;
                        lengthTwo = 0;

                        if (right != false)
                        {
                            if (upColomn >= 39)    // Условная конструкция, которая выполняется когда цепочка подходит к нижней границе консоли
                            {
                                if (matrixOne.Length - 1 == 0)
                                {
                                    upColomn = 0;
                                    right = false;  // Отключаем процесс создания первой цепочки
                                    continue;
                                }
                                matrixOne = new string[matrixOne.Length - 1];
                                for (int h = 0; h < matrixOne.Length; h++)            // Инициализация елементов одномерного массива строкового типа
                                {
                                    matrixOne[h] = literals[random.Next(35)].ToString();
                                }
                            }
                        }

                        if (upColomnTwo >= 39)    // Условная конструкция, которая выполняется когда цепочка подходит к нижней границе консоли
                        {
                            if (matrixTwo.Length - 1 == 0)
                            {
                                upColomnTwo = 0;
                                right = true;    // После завершения цикла появления и исчезновения цепочек в консоли, включаем процесс создания первой цепочки
                                break;
                            }
                            matrixTwo = new string[matrixTwo.Length - 1];
                            for (int h = 0; h < matrixTwo.Length; h++)            // Инициализация елементов одномерного массива строкового типа
                            {
                                matrixTwo[h] = literals[random.Next(35)].ToString();
                            }
                        }



                        // Циклическая конструкция, которая выводит в консоли в столбце пошагово литералы (сверху вниз).
                        if (right != false)
                        {
                            for (int i = 0; i < matrixOne.Length; i++)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = upColomn++;

                                // Условная конструкция, отвечающая за разное цветовое отображение в консоли литералов. Первый литерал - белого цвета, второй - светло-зеленый, третий и далее - темно-зеленые.
                                if (lengthOne == matrixOne.Length - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (lengthOne == matrixOne.Length - 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                matrixOne[i] = literals[random.Next(35)].ToString();
                                Console.Write(matrixOne[i]);
                                lengthOne++;
                            }
                        }


                        // Условная конструкция для появления в столбце второй цепочки литералов
                        if (Console.CursorTop >= indentThread)
                        { 
                            for (int i = 0; i < matrixTwo.Length; i++)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = upColomnTwo++;

                                // Условная конструкция, отвечающая за разное цветовое отображение в консоли литералов. Первый литерал - белого цвета, второй - светло-зеленый, третий и далее - темно-зеленые.
                                if (lengthTwo == matrixTwo.Length - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (lengthTwo == matrixTwo.Length - 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                matrixTwo[i] = literals[random.Next(35)].ToString();
                                Console.Write(matrixTwo[i]);
                                lengthTwo++;
                            }
                        }


                        Thread.Sleep(5);

                        

                    }
                }
            }
        }
    }
}
