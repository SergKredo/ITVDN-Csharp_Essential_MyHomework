using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
            /*Задание 3
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
        Присвойте каждой константе значение, задающее количество часов, которые должен отработать
        сотрудник за месяц.
        Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее
        давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему
        положена премия.*/
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Automatic bonus calculation for company employees: ".ToUpper());
            Console.WriteLine(new string('-', 50));
            Accauntant accauntant = new Accauntant();  // Создание экземпляра класса для расчета премий для сотрудников компании
            accauntant.Sorting();   

            Console.ReadKey();



        }
    }
}
