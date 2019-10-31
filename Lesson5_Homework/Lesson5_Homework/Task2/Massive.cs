using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Massive
    {
        Random random = new Random();  // Экземпляр класса Random для определения массива беспорядочных чисел
        private int[] massivetwo;      // Объявление одномерного массива
        public Massive(int[] massive)   // Пользовательский конструктор класса Massive
        {
            this.massivetwo = massive;
           
                for (int i = 0; i < massivetwo.Length; i++)
                {
                    massivetwo[i] = random.Next(0, 1000);
                }
                Console.Write("Numbers random massive: ");
                foreach (int k in massivetwo)
                {
                    Console.Write(k + "; ");
                }
           
            
        }
        public int this[int index]   // Индексатор массива
        {
            get
            {
                return massivetwo[index];
            }
            set
            {
                massivetwo[index] = value;
            }
        }
        public void MaxNumber() //  Метод для определения максимального значения числа в массиве
        {
            Console.WriteLine("\nMaximum number: "+ massivetwo.Max()+ ";");
        }
        public void MinNumber()  //  Метод для определения минимального значения числа в массиве
        {
            Console.WriteLine("Minimum number: " + massivetwo.Min() + ";");
        }
        public void Sum()   //  Метод для определения суммы всех значений чисел в массиве
        {
            Console.WriteLine("Sum numbers: " + massivetwo.Sum() + ";");
        }
        public void ArithmeticMean()  //  Метод для определения среднего арифметического чисел в массиве
        {
            Console.WriteLine("Arithmetic mean numbers: " + massivetwo.Average() + ";");
        }
        public void OddValues()   //  Метод для нахождения всех нечетных значений чисел в массиве
        {
            Console.Write("Odd values numbers: ");
            for (int i = 0; i < massivetwo.Length; i++)
            {
                int k = massivetwo[i] >> 1; // Побитовый сдвиг значения числа вправо на один бит
                if (massivetwo[i] != k*2)   // Проверка на четность и нечетность
                {
                    Console.Write(massivetwo[i]+"; ");
                }
            }
            Console.WriteLine("\n"+new string('-', 100));   // Подчеркивание линией штриховых знаков
            Console.WriteLine(new string('-', 100));
        }
    }
}
