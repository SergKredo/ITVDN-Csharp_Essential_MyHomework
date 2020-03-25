using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Задание 4
Создайте класс, который будет содержать информацию о дате (день, месяц, год). С помощью
механизма перегрузки операторов, определите операцию разности двух дат (результат в виде
количества дней между датами), а также операцию увеличения даты на определенное количество дней.*/

        // Класс, который формирует дату
    class Date
    {
        DateTime time;   // Поле структура типа DateTime для определения даты, введенной пользователем в консоли
        public Date()  // Конструктор по умолчанию
        {

        }
        public Date(DateTime date)  //Пользовательский конструктор, который принимает один агрумент типа DateTime
        {
            this.time = date;   // Инициализация поля текущего экземпляра объекта в конструкторе
        }

        public static int operator -(Date dateOne, Date dateTwo)   // Перегрузка оператора -. Операция перегрузки позволяет расчитать количество дней между двумя датами
        {
            TimeSpan differenceTime = dateOne.time - dateTwo.time;
            return differenceTime.Days;
        }

        public static Date operator +(Date date, int days)    // Перегрузка оператора +. Операция перегрузки позволяет увеличить заданную пользователем дату на определенное количество дней
        {
            Date dateAddDays = new Date();
            dateAddDays.time = date.time.AddDays(days);
            return dateAddDays;
        }

        public override string ToString()   // Переопределение метода ToString базового класса Object
        {
            return string.Format("[{0}, {1}, {2}]", this.time.Year, this.time.Month, this.time.Day);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try  // Конструкция try-catch на обработку исключений
            {
                Console.WriteLine("Date information using operator overloads:".PadLeft(50).ToUpper());
                Console.WriteLine(new string('-', 70));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("- The number of days between two dates:".ToUpper());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("First date: ".PadLeft(14));
                DateTime firstDate = Convert.ToDateTime(Console.ReadLine());   
                Console.Write("Second date: ".PadLeft(15));
                DateTime secondDate = Convert.ToDateTime(Console.ReadLine());
                Date dateOne = new Date(firstDate);
                Date dateTwo = new Date(secondDate);
                int difference = dateOne - dateTwo;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(string.Format("Days difference between {0} - {1}: {2} days;", dateOne.ToString(), dateTwo.ToString(), difference).PadLeft(67));
                Console.ForegroundColor = ConsoleColor.Gray;


                Console.WriteLine("\n" + new string('-', 70));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n- Increase the date by a certain number of days:".ToUpper());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter date: ".PadLeft(14));
                DateTime thirdDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the number of days: ".PadLeft(28));
                int increaseDays = Convert.ToInt32(Console.ReadLine());
                Date dateThree = new Date(thirdDate);
                string dateNameThird = dateThree.ToString();
                dateThree += increaseDays;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Format("Date {0} increase by {1} days: {2};", dateNameThird, increaseDays, dateThree.ToString()).PadLeft(57));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный формат даты!");
                Console.ReadKey();
            }
        }
    }
}
