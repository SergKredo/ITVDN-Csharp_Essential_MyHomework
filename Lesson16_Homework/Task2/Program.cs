using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Задание 2
Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
Equals – способный сравнивать блоки между собой,
ToString – возвращающий информацию о полях блока.*/

        // Класс для построения блоков
    class Block
    {
        int sideOne;    // Целочисленное поле определяющее сторону 1
        int sideTwo;   // Целочисленное поле определяющее сторону 2
        int sideThree;   // Целочисленное поле определяющее сторону 3
        int sideFour;   // Целочисленное поле определяющее сторону 4

        public Block(int sideOne, int sideTwo, int sideThree, int sideFour)          // Пользовательский конструктор для инициализации полей класса
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.sideThree = sideThree;
            this.sideFour = sideFour;
        }

        public override bool Equals(object obj)                 // Переопределение метода Equals базового класса Object
        {
            // Условная конструкция, которая проверяет блоки на равенство их сторон
            if ((obj as Block).sideOne != this.sideOne || (obj as Block).sideTwo != this.sideTwo || (obj as Block).sideThree != this.sideThree || (obj as Block).sideFour != this.sideFour)
            {
                return false;       // Стороны блоков не равны между собою
            }
            else
            {
                return true;       // Стороны блоков равны между собою
            }
        }


        public override string ToString()              //Переопределение метода ToString базового класса Object
        {
            Type type = this.GetType();              // Присвоение переменной type основной информации об текущем экземпляре объекта класса Block
            return string.Format("with sides: a = {1}, b = {2}, c = {3}, d = {4}", type.ToString(), sideOne, sideTwo, sideThree, sideFour);                // Метод возвращает информацию о 4-х сторонах текущего блока
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Block blockOne = new Block(1, 2, 3, 5);   // Создание 1-го экземпляра класса Block и передача в конструктор целочисленных аргументов 4-х сторон
            Block blockTwo = new Block(1, 2, 4, 5);   // Создание 2-го экземпляра класса Block и передача в конструктор целочисленных аргументов 4-х сторон


            // Вывод в консоли информации о равенстве сторон 2-х блоков
            if (blockTwo.Equals(blockOne) != true)
            {
                Console.WriteLine("Block 2 " + blockTwo.ToString() + " not equal " + "Block 1 " + blockOne.ToString());
            }
            else
            {
                Console.WriteLine("Block 2 " + blockTwo.ToString() + " is equal to " + "Block 1 " + blockOne.ToString());
            }

            Console.WriteLine(new string('-', 110));

            Block blockThree = new Block(1, 2, 3, 5);   // Создание 3-го экземпляра класса Block и передача в конструктор целочисленных аргументов 4-х сторон
            Block blockFour = new Block(1, 2, 3, 5);   // Создание 4-го экземпляра класса Block и передача в конструктор целочисленных аргументов 4-х сторон


            // Вывод в консоли информации о равенстве сторон 2-х блоков
            if (blockFour.Equals(blockThree) != true)
            {
                Console.WriteLine("Block 2 " + blockFour.ToString() + " not equal " + "Block 1 " + blockThree.ToString());
            }
            else
            {
                Console.WriteLine("Block 2 " + blockFour.ToString() + " is equal to " + "Block 1 " + blockThree.ToString());
            }
            Console.ReadKey();
        }
    }
}
