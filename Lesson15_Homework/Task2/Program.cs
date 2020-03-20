using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Task2
{
    /*Задание 2
Требуется: Описать структуру с именем Worker, содержащую следующие поля:
• фамилия и инициалы работника;
• название занимаемой должности;
• год поступления на работу.
Написать программу, выполняющую следующие действия:
• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны
быть упорядочены по алфавиту);
• если значение года введено не в соответствующем формате выдает исключение.
• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.*/

        
    struct Worker // Структура для формирования данных о сотруднике, который работает в компании
    {
        public string surnameAndEmployeeInitials;  // Открытое строковое поле "фамилия и инициалы работника"
        public string position;                    // Открытое строковое поле "название занимаемой должности"
        public DateTime yearOfEmployment;          // Открытое поле типа DateTime для определения "год поступления на работу"
        public int numberLiteralInAlphabet;        // Открытое целочисленное поле для определения индекса первого литерала из ряда алфавита для конкретного языка

        public Worker(string surname, string position, DateTime yearOfEmployment, int numberLiteralInAlphabet)  // Пользовательский конструктор с 4-мя входящими параметрами
        {
            // Инициализация полей структуры
            this.surnameAndEmployeeInitials = surname;
            this.position = position;
            this.yearOfEmployment = yearOfEmployment;
            this.numberLiteralInAlphabet = numberLiteralInAlphabet;
        }
    }


    class Program
    {
        static int IndexLiterals(char literal, string language) // Статический метод для определения индекса первого литерала фамилии сотрудника в ряде алфавита языков
        {
            string alphabetEngBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";   // Ряд прописных букв английского алфавита
            string alphabetEngSmall = alphabetEngBig.ToLower();     // Ряд строчных букв английского алфавита
            string alphabetRusBig = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";  // Ряд прописных букв русского алфавита
            string alphabetRusSmall = alphabetRusBig.ToLower();       // Ряд строчных букв русского алфавита
            string alphabetUkrSmall = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";   // Ряд строчных букв украинского алфавита
            string alphabetUkrBig = alphabetUkrSmall.ToUpper();   // Ряд прописных букв украинского алфавита

            switch (language)      // Конструкция switch-case для определения типа языка и индекса первого литерала в ряде алфавита
            {
                case "ru-RU":   // Русский язык
                    {
                        if (alphabetRusBig.Contains(literal.ToString().ToUpper()))  // Условная конструкция, которая проверяет нахождение данного литерала
                        {
                            return alphabetRusBig.IndexOf(literal.ToString().ToUpper());
                        }
                        if (alphabetRusSmall.Contains(literal.ToString().ToLower()))
                        {
                            return alphabetRusSmall.IndexOf(literal.ToString().ToLower());
                        }
                        break;
                    }
                case "en-US":   // Английский язык
                    {
                        if (alphabetEngBig.Contains(literal.ToString().ToUpper()))
                        {
                            int index = alphabetEngBig.IndexOf(literal.ToString().ToUpper());
                            return alphabetEngBig.IndexOf(literal.ToString().ToUpper());
                        }
                        if (alphabetEngSmall.Contains(literal.ToString().ToLower()))
                        {
                            int index = alphabetEngSmall.IndexOf(literal.ToString().ToLower());
                            return alphabetEngSmall.IndexOf(literal.ToString().ToLower());
                        }
                        break;
                    }
                case "uk-UA":  // Украинский язык
                    {
                        if (alphabetUkrBig.Contains(literal.ToString().ToUpper()))
                        {
                            return alphabetUkrBig.IndexOf(literal.ToString().ToUpper());
                        }
                        if (alphabetUkrSmall.Contains(literal.ToString().ToLower()))
                        {
                            return alphabetUkrSmall.IndexOf(literal.ToString().ToLower());
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }


        // Статический метод, который определяет язык алфавита, на котором пользователь заполнял список сотрудников
        static string LanguageDefinition(string surname)
        {
            string alphabetEngBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphabetEngSmall = alphabetEngBig.ToLower();
            string alphabetRusBig = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string alphabetRusSmall = alphabetRusBig.ToLower();
            string alphabetUkrSmall = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
            string alphabetUkrBig = alphabetUkrSmall.ToUpper();
            // Целочисленные поля, которые определяют количество вхождений литералов "фамилия и инициалы сотрудника" в ряде языка алфавита
            int countEngBig = 0;
            int countEngSmall = 0;
            int countRusBig = 0;
            int countRusSmall = 0;
            int countUkrBig = 0;
            int countUkrSmall = 0;
            string language = null;   // Строковое поле, которое принимает название языка ввода данных в списке
            for (int i = 0; i < surname.Length; i++)  // Последовательный перебор всех букв введенного пользователем слова
            {
                for (int j = 0; j < alphabetEngBig.Length; j++)  // Последовательный перебор всех букв алфавита
                {
                    bool coincidence = (surname[i] == alphabetEngBig[j]) ? true : false;  // Булевая проверка на совпадение буквы введенного пользователем слова с буквой алфавита
                    if (coincidence == true)
                    {
                        ++countEngBig; // Если буква встретилась в ряде букв алфавита, тогда значение счета переменной увеличивается на единицу
                    }
                }
                for (int j = 0; j < alphabetEngSmall.Length; j++)
                {
                    bool coincidence = (surname[i] == alphabetEngSmall[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countEngSmall;
                    }
                }
                for (int j = 0; j < alphabetRusBig.Length; j++)
                {
                    bool coincidence = (surname[i] == alphabetRusBig[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countRusBig;
                    }
                }
                for (int j = 0; j < alphabetRusSmall.Length; j++)
                {
                    bool coincidence = (surname[i] == alphabetRusSmall[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countRusSmall;
                    }
                }
                for (int j = 0; j < alphabetUkrBig.Length; j++)
                {
                    bool coincidence = (surname[i] == alphabetUkrBig[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countUkrBig;
                    }
                }
                for (int j = 0; j < alphabetUkrSmall.Length; j++)
                {
                    bool coincidence = (surname[i] == alphabetUkrSmall[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countUkrSmall;
                    }
                }
            }
            int[] massive = { countEngBig, countEngSmall, countRusBig, countRusSmall, countUkrBig, countUkrSmall };  // Целочисленный массив всех переменных счета совпадения букв для конкретного языка
            int maxValueOfMassive = massive.Max();   // Определение максимального значения счета на совпадение букв ввода с буквами алфавита
            if ((massive[2] == massive[4]) && massive[4] == maxValueOfMassive)  // Условные конструкции для перебора наибольшего совпадения букв ввода с буквами алфавита языков
            {
                language = "ru-RU";
            }
            else if ((massive[3] == massive[5]) && massive[5] == maxValueOfMassive)
            {
                language = "ru-RU";
            }
            else
            {
                if (massive[0] == maxValueOfMassive || massive[1] == maxValueOfMassive)
                {
                    language = "en-US";
                }
                else if (massive[2] == maxValueOfMassive || massive[3] == maxValueOfMassive)
                {
                    language = "ru-RU";
                }
                else if (massive[4] == maxValueOfMassive || massive[5] == maxValueOfMassive)
                {
                    language = "uk-UA";
                }
            }

            return language;


        }


        // Статический метод, который сортирует данные о сотруднике компании по алфавиту
        static public List<Worker> SortWorkerToSurname(List<Worker> workers)
        {
            List<Worker> SortList = new List<Worker>();  // Создание экземпляра коллекции из сортированных данных всех сотрудников компании
            List<int> massiveSorterWorkerIndex = new List<int>();  // Создание экземпляра коллекции из данных всех индексов первых литералов ввода фамилии сотрудника
            for (int a = 0; a < workers.Count; a++)
            {
                massiveSorterWorkerIndex.Add(workers[a].numberLiteralInAlphabet); // Добавление элемента данных о сотруднике в список
            }

            while (workers.Count > 0)
            {
                int minValueList = massiveSorterWorkerIndex.Min();   // Определение минимального значения индекса вхождения литералов ввода данных сотрудников в ряде алфавита
                for (int l = 0; l < workers.Count; l++)
                {
                    if (massiveSorterWorkerIndex[l] == minValueList)
                    {
                        SortList.Add(workers[l]);
                        workers.RemoveAt(l);        // Удаление из списка входящего аргумента данных о сотруднике, который определился сортировщиком
                        massiveSorterWorkerIndex.RemoveAt(l); // Удаление из списка элемента-данных об индексе первой буквы фамилии сотрудника, который определился сортировщиком
                    }
                }
            }

            return SortList;
        }


        // Статический метод, который сортирует список сотрудников по превышению стажа работы сотрудника введенного пользователем
        static public List<Worker> SortWorkerToExperience(List<Worker> workers, int ultimateExperience, ref List<int> countMassive)
        {
            List<Worker> SortWorkerToExperience = new List<Worker>();
            int count = 1;
            foreach (Worker worker in workers)
            {
                int time = DateTime.Now.Year - worker.yearOfEmployment.Year;  // Определение стажа работы сотрудника
                if (time > ultimateExperience)  // Условная конструкция проверяет превышает ли предельный стаж от стажа конкретного сотрудника в компании
                {
                    SortWorkerToExperience.Add(worker);
                    countMassive.Add(count);
                }
                count++;
            }

            return SortWorkerToExperience;

        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(125, 30);
            string surname = null;
            string position = null;
            DateTime yearOfEmployment = DateTime.Now;
            int numberLiteralInAlphabet;
            string language = null;
            int count = 1;
            int countCursor = 0;
            int workExperience = 0;
            bool ultimateExperience = false;
            List<Worker> Mycollection = new List<Worker>();
            Console.WriteLine("List of employees:".ToUpper().PadLeft(30));
            while (Mycollection.Count < 5)
            {
                Console.CursorLeft = 2;
                Console.WriteLine(new string('-', 55));
                Console.CursorLeft = 2;
                Console.Write("Surname and initials of the {0} employee: ", count);
                surname = Console.ReadLine();
                Console.CursorLeft = 2;
                Console.Write("{0}st employee position: ", count++);
                position = Console.ReadLine();
            Again:
                Console.CursorLeft = 2;
                Console.Write("Year of employment: ");
                try                   // Обработка програмного исключения в случае неправильного ввода даты начала работы сотрудника
                {
                    yearOfEmployment = Convert.ToDateTime(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorLeft = 2;
                    Console.WriteLine("Ошибка! " + e.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    goto Again;
                }
                language = LanguageDefinition(surname);
                numberLiteralInAlphabet = IndexLiterals(surname[0], language);
                Mycollection.Add(new Worker(surname, position, yearOfEmployment, numberLiteralInAlphabet));
                Console.CursorLeft = 2;
                Console.WriteLine(new string('-', 55));
            }

            count = 1;

            List<Worker> SortCollection = SortWorkerToSurname(Mycollection);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorTop = countCursor++;
            Console.CursorLeft = 65;
            Console.WriteLine("List of employees in alphabetical order:".ToUpper().PadLeft(45));
            foreach (Worker element in SortCollection)
            {
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine(new string('-', 55));
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("Surname and initials of the {0} employee: {1}", count, element.surnameAndEmployeeInitials);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("{0}st employee position: {1}", count++, element.position);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("Year of employment: {0}", element.yearOfEmployment);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine(new string('-', 55));
                Thread.Sleep(50);
            }
            count = 1;
            while (count++ < 3)
            {
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine(new string('-', 55));
                Thread.Sleep(10);
            }

            List<int> countMassive = new List<int>();
            Console.CursorTop = countCursor++;
            Console.CursorLeft = 65;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the ultimate experience of employee performance: ".ToUpper());
            workExperience = Convert.ToInt32(Console.ReadLine());
            List<Worker> worker = SortWorkerToExperience(SortCollection, workExperience, ref countMassive);
            
            countMassive.Reverse();
            count = 1;

            foreach (Worker element in worker)
            {
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine(new string('-', 55));
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("Surname and initials of the {0} employee: {1}", countMassive[worker.Count - count], element.surnameAndEmployeeInitials);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("{0}st employee position: {1}", countMassive[worker.Count - count++], element.position);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("Year of employment: {0}", element.yearOfEmployment);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine(new string('-', 55));
                ultimateExperience = true;
                Thread.Sleep(50);
            }

            if (!ultimateExperience)   // Условная конструкция для проверки на отсутствие вывода данных о сотрудниках в случае превышения предела стажа
            {
                Console.CursorTop = countCursor;
                Console.CursorLeft = 65;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("All employees have less work experience!");
            }
            Console.ReadKey();
        }
    }
}
