using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Additional_Task
{
        /*Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить
    количество дней до его следующего дня рождения.*/
    
    class Program
    {
        
        static void Main(string[] args)
        {
            try  // Позволяет сработать программе в случае вывода исключения
            {
                Console.WriteLine(new string('-', 100));
                Console.WriteLine("Программа для расчета количества оставшихся дней\nот текущего дня рождения до следующего дня рождения.".ToUpper());
                Console.WriteLine(new string('-', 100));
                DateTime date = new DateTime();
                Again:
                Console.Write("Введите пожалуйста текущую дату своего дня рождения (25.09.1986): ");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(new string('-', 100));
                string headerThisYear = "Текущий год дня рождения";
                Console.Write(headerThisYear.ToUpper()+" - {0}: ", date.Year);
                DataBirthday dataBirthday = new DataBirthday(date);
                dataBirthday.DateThisYear();
                Console.WriteLine(new string('-', 100));
                dataBirthday.DateNextYear();
                Console.WriteLine(new string('-', 100));
                Console.Write("Количество дней от текущего дня Рождения до следующего дня Рождения: ".ToUpper()+dataBirthday.SpanTime(date)+" дней.\n");
                Console.WriteLine(new string('-', 100));
                Console.Write("Количество дней от текущего дня до введенного пользователем дня Рождения: ".ToUpper() + dataBirthday.SpanTimeYear(date) + " дней.\n");
                Console.WriteLine(new string('-', 100));
                Console.WriteLine(new string('-', 100));
                goto Again;

            }
            catch 
            {
                Console.WriteLine("Введенное Вами значение числа дня месяца не входит в заданных диапазон значений дней месца для этого года и месяца!");
            }
            Console.ReadKey();
        }
    }
}
