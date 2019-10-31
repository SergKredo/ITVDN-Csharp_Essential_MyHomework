using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов.*/

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
            int count = 0;
            MyList<int> list = new MyList<int>();

            list.DefinitionObjects();
            Console.Write("\n- Information about element massive.".ToUpper()+ " Please enter the element number of the array: ".ToUpper());
            int numberMassive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[numberMassive, count]);
            Console.WriteLine("- Sum of all array elements: {0}".ToUpper(), list.Count);
            ++count;
            Console.WriteLine(new string('-', 70));

            Console.Write("\n"+ new string(' ', 10) + "- Add element to previous massive: ".ToUpper());
            object[] variable = {"hello", 'r', 546664565m, false, (short)255};
            list.Add(variable);
            Console.Write("\n- Information about element massive.".ToUpper() + " Please enter the element number of the array: ".ToUpper());
            numberMassive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[numberMassive, count]);
            Console.WriteLine("- Sum of all array elements: {0}".ToUpper(), list.Count);
            Console.WriteLine(new string('-', 70));

            Console.Write("\n" + new string(' ', 10) + "- Add element to previous massive: ".ToUpper());
            object[] variable2 = { "hello", true, 12.5d, (long)15646565, 'r', 546664565m, false, (short)255 };
            list.Add(variable2);
            Console.Write("\n- Information about element massive.".ToUpper() + " Please enter the element number of the array: ".ToUpper());
            numberMassive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[numberMassive, count]);
            Console.WriteLine("- Sum of all array elements: {0}".ToUpper(), list.Count);
            Console.WriteLine(new string('-', 70));

            Console.Write("\n" + new string(' ', 10) + "- Add element to previous massive: ".ToUpper());
            object[] variable3 = { true, 12.5d, (long)15646565, (short)-153, 546664565m, false, (short)255, "ITVD rulit"};
            list.Add(variable3);
            Console.Write("\n- Information about element massive.".ToUpper() + " Please enter the element number of the array: ".ToUpper());
            numberMassive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[numberMassive, count]);
            Console.WriteLine("- Sum of all array elements: {0}".ToUpper(), list.Count);
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(new string('-', 70));

            Console.ReadKey();
            }
        }
    }
}
