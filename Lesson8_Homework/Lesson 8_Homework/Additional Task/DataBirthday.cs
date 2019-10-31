using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class DataBirthday
    {
        DateTime birthday, dateNextYear, dataTimeLeapYear;
        DateTime timeNow = DateTime.Now;
        int[][] daysToMonth = new int[12][];
        int addyear;
        enum nameMonth  // Объявление перечисления с набором именованых констант месяцев года
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public DataBirthday(DateTime date)
        {
            this.birthday = date;
        }
        public void DefinitionYear()   // Метод для определения типа года: высокостный или невысокостный год.
        {
            if (birthday.Day > 0)
            {
                if (birthday.Year % 400 != 0)     // Условная конструкция согласно которой высокостным годом является год, который можно без остатка разделить на 4 или для сотен, тысяч на 400.
                {
                    if (birthday.Year % 4 != 0 || birthday.Year % 100 == 0)  // Год, который имеет числовое значение сотни или тысячи и делится на 100 не является высокостным годом
                    {
                        Console.WriteLine("невысокостный год, в котором 365 дней в году");
                        CountDaysToMonthToNotLeapYear();
                    }
                }
                if (birthday.Year % 4 == 0)
                {
                    Console.WriteLine("высокостный год, в котором 366 дней в году");
                    CountDaysToMonthToLeapYear();
                }
            }
        }
        public void DefinitionLeapOrNotLeapYear()
        {
            nameMonth name = nameMonth.January;
            for (int i = 0; i < daysToMonth.Length; i++)
            {
                if ((int)name != birthday.Month)
                {
                    Console.Write(name + ": ");

                    for (int j = 0; j < daysToMonth[i].Length; j++)
                    {
                        daysToMonth[i][j] = j + 1;
                        if ((int)name != timeNow.Month)
                        {
                            if (daysToMonth[i][j] != timeNow.Day)
                            {
                                Console.Write(daysToMonth[i][j] + " ");
                            }
                            else
                            {
                                Console.Write(daysToMonth[i][j] + " ");
                            }
                        }
                        else
                        {
                            if (daysToMonth[i][j] != timeNow.Day)
                            {
                                Console.Write(daysToMonth[i][j] + " ");
                            }
                            else if (!(birthday.Year < timeNow.Year || birthday.Year > timeNow.Year))
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(daysToMonth[i][j]);
                                Console.Write(" " + "(Data time now: {0})", timeNow.DayOfWeek);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write(daysToMonth[i][j] + " ");
                            }
                        }
                    }
                    ++name;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(name + ": ");
                    for (int j = 0; j < daysToMonth[i].Length; j++)
                    {
                        daysToMonth[i][j] = j + 1;
                        if (daysToMonth[i][j] != birthday.Day)
                        {
                            if (timeNow.Month > birthday.Month || timeNow.Month < birthday.Month)
                            {
                                Console.Write(daysToMonth[i][j] + " ");
                            }
                            else
                            {
                                if (daysToMonth[i][j] == timeNow.Day && !(birthday.Year < timeNow.Year || birthday.Year > timeNow.Year))
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(daysToMonth[i][j]);
                                    Console.Write(" " + "(Data time now: {0})", timeNow.DayOfWeek);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write(daysToMonth[i][j] + " ");
                                }
                            }
                        }
                        else
                        {
                            if (timeNow.Day != birthday.Day)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(daysToMonth[i][j]);
                                Console.Write(" " + "({0})", birthday.DayOfWeek);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write(" ");
                            }
                            else if (!(birthday.Year < timeNow.Year || birthday.Year > timeNow.Year))
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(daysToMonth[i][j]);
                                Console.Write(" " + "(Data time now and my birthday: {0})", birthday.DayOfWeek);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(daysToMonth[i][j]);
                                Console.Write(" " + "({0})", birthday.DayOfWeek);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write(" ");
                            }
                        }
                    }
                    ++name;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();
            }
        }
        public void CountDaysToMonthToLeapYear() // Метод, который выводит массив данных месяцев и дней для каждого месяца выосокостного года
        {
            daysToMonth = new int[12][] { new int[31], new int[29], new int[31], new int[30], new int[31], new int[30], new int[31], new int[31], new int[30], new int[31], new int[30], new int[31] };  // Зубчатый массив, в котором опеределены 12 одномерных подмассивов, характеризующих месяцы и дни.
            DefinitionLeapOrNotLeapYear();
        }
        public void CountDaysToMonthToNotLeapYear()  // Метод, который выводит массив данных месяцев и дней для каждого месяца невыосокостного года
        {
            daysToMonth = new int[12][] { new int[31], new int[28], new int[31], new int[30], new int[31], new int[30], new int[31], new int[31], new int[30], new int[31], new int[30], new int[31] };
            DefinitionLeapOrNotLeapYear();
        }
        public void DateThisYear()  // Метод, который выводит в консоли массив информации о текущем годе дня рождения
        {
            DefinitionYear();
        }
        public void DateNextYear()  // Метод, который выводит в консоли массив информации о следующем годе дня рождения
        {
            dateNextYear = new DateTime();
            if (birthday.Month == 2 && birthday.Day == 29)  // Условная конструкция, которая определяет когда будет следующий день рождения 29 февраля высокостного года
            {
                dataTimeLeapYear = birthday;
                addyear = dataTimeLeapYear.Year;
                for (int i = 1; true; i++)
                {
                    addyear++;
                    if ((addyear % 4 == 0 && addyear % 100 != 0) || addyear % 400 == 0)
                    {
                        dataTimeLeapYear = dataTimeLeapYear.AddYears(i);
                        this.birthday = dataTimeLeapYear;
                        dateNextYear = dataTimeLeapYear;
                        string headerNextYear = "Следующий год дня рождения";
                        Console.Write(headerNextYear.ToUpper() + " - {0}: ", addyear);
                        DefinitionYear();
                        break;
                    }
                }
            }
            else
            {
                dateNextYear = this.birthday.AddYears(1);
                this.birthday = dateNextYear;
                string headerNextYear = "Следующий год дня рождения";
                Console.Write(headerNextYear.ToUpper() + " - {0}: ", dateNextYear.Year);
                DefinitionYear();
            }
        }
        public int SpanTime(DateTime date)  // Метод, который позволяет рассчитать количество дней между текущей датой дня рождения и следующей датой дня рождения
        {
            this.birthday = date;
            TimeSpan spantime = dateNextYear.Date - birthday.Date;
            return spantime.Days;
        }
        public int SpanTimeYear(DateTime date)  // Метод, который позволяет рассчитать количество дней между текущей датой и введенной пользователем датой дня рождения
        {
            this.birthday = date;
            if (birthday >= timeNow && birthday.Year != birthday.Year+1)   
            {
                TimeSpan timeSpan = birthday - timeNow;
                return timeSpan.Days;
            }
            else if (birthday >= timeNow && birthday.Year > timeNow.Year)
            {
                TimeSpan timeSpan = dateNextYear - timeNow;
                return timeSpan.Days;
            }
            else
            {
                TimeSpan timeSpan = timeNow-birthday;
                return -timeSpan.Days;
            }
        }
    }
}
