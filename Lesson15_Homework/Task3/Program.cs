using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Task3
{
        /*Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: Описать структуру с именем Price, содержащую следующие поля:
    • название товара;
    • название магазина, в котором продается товар;
    • стоимость товара в гривнах.
    Написать программу, выполняющую следующие действия:
    • ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны
    быть упорядочены в алфавитном порядке по названиям магазинов);
    • вывод на экран информации о товарах, продающихся в магазине, название которого введено с
    клавиатуры (если такого магазина нет, вывести исключение).*/

    struct Price   // Структура для формирования данных о товарах
    {
        public string productName;  // Открытое строковое поле "название товара"
        public string storeName;    // Открытое строковое поле "название магазина, в котором продается товар"
        public float costOfGoods;   // Открытое поле с плавающей запятой типа float для определения стоимости товара в гривнах
        public int numberLiteralInAlphabet;   // Открытое целочисленное поле для определения индекса первого литерала из ряда алфавита для конкретного языка

        public Price(string productName, string storeName, float costOfGoods, int numberLiteralInAlphabet)   // Пользовательский конструктор с 4-мя входящими параметрами
        {
            this.productName = productName;
            this.storeName = storeName;
            this.costOfGoods = costOfGoods;
            this.numberLiteralInAlphabet = numberLiteralInAlphabet;
        }
    }

    // Пользовательский класс генерации исключения
    class MyException : Exception  // Наследование от базового класса Exception
    {
        string exception = "Such a store is not in the list of goods!";

        public override string Message   // Переопределение свойства Message базового класса Exception. Возвращает сообщение об ошибке с объяснением причин исключения или пустую строку ("")
        {
            get
            {
                return exception;
            }
        }

    }

    class Program
    {
        // Статический метод, который определяет язык алфавита, на котором пользователь заполнял список товаров
        static string LanguageDefinition(string storeName)
        {
            string alphabetEngBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphabetEngSmall = alphabetEngBig.ToLower();
            string alphabetRusBig = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string alphabetRusSmall = alphabetRusBig.ToLower();
            string alphabetUkrSmall = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
            string alphabetUkrBig = alphabetUkrSmall.ToUpper();
            // Целочисленные поля, которые определяют количество вхождений литералов "название магазина" в ряде языка алфавита
            int countEngBig = 0;
            int countEngSmall = 0;
            int countRusBig = 0;
            int countRusSmall = 0;
            int countUkrBig = 0;
            int countUkrSmall = 0;
            string language = null;   // Строковое поле, которое принимает название языка ввода данных в списке
            for (int i = 0; i < storeName.Length; i++)  // Последовательный перебор всех букв введенного пользователем слова
            {
                for (int j = 0; j < alphabetEngBig.Length; j++)  // Последовательный перебор всех букв алфавита
                {
                    bool coincidence = (storeName[i] == alphabetEngBig[j]) ? true : false;  // Булевая проверка на совпадение буквы введенного пользователем слова с буквой алфавита
                    if (coincidence == true)
                    {
                        ++countEngBig; // Если буква встретилась в ряде букв алфавита, тогда значение счета переменной увеличивается на единицу
                    }
                }
                for (int j = 0; j < alphabetEngSmall.Length; j++)
                {
                    bool coincidence = (storeName[i] == alphabetEngSmall[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countEngSmall;
                    }
                }
                for (int j = 0; j < alphabetRusBig.Length; j++)
                {
                    bool coincidence = (storeName[i] == alphabetRusBig[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countRusBig;
                    }
                }
                for (int j = 0; j < alphabetRusSmall.Length; j++)
                {
                    bool coincidence = (storeName[i] == alphabetRusSmall[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countRusSmall;
                    }
                }
                for (int j = 0; j < alphabetUkrBig.Length; j++)
                {
                    bool coincidence = (storeName[i] == alphabetUkrBig[j]) ? true : false;
                    if (coincidence == true)
                    {
                        ++countUkrBig;
                    }
                }
                for (int j = 0; j < alphabetUkrSmall.Length; j++)
                {
                    bool coincidence = (storeName[i] == alphabetUkrSmall[j]) ? true : false;
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


        static int IndexLiterals(char literal, string language) // Статический метод для определения индекса первого литерала "названия магазина" в ряде алфавита языков
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


        // Статический метод, который сортирует данные названия магазина по алфавиту
        static public List<Price> SortStoreToName(List<Price> storeName)
        {
            List<Price> SortList = new List<Price>();  // Создание экземпляра коллекции из сортированных данных всех данных товаров
            List<int> massiveSorterStoreNameIndex = new List<int>();  // Создание экземпляра коллекции из данных всех индексов первых литералов ввода названия магазина
            for (int a = 0; a < storeName.Count; a++)
            {
                massiveSorterStoreNameIndex.Add(storeName[a].numberLiteralInAlphabet); // Добавление элемента данных о товаре в список
            }

            while (storeName.Count > 0)
            {
                int minValueList = massiveSorterStoreNameIndex.Min();   // Определение минимального значения индекса вхождения литералов ввода данных товаров в ряде алфавита
                for (int l = 0; l < storeName.Count; l++)
                {
                    if (massiveSorterStoreNameIndex[l] == minValueList)
                    {
                        SortList.Add(storeName[l]);
                        storeName.RemoveAt(l);        // Удаление из списка входящего аргумента данных о товаре, который определился сортировщиком
                        massiveSorterStoreNameIndex.RemoveAt(l); // Удаление из списка элемента-данных об индексе первой буквы названия магазина, который определился сортировщиком
                    }
                }
            }

            return SortList;
        }

        // Статический метод, который осуществляет поиск товаров по названию магазина
        static public List<Price> FindStoreToName(List<Price> listStores, string sortStoreName, ref List<int> countMassive)
        {
            List<Price> FindSoresToNames = new List<Price>();
            int count = 1;
            foreach (Price store in listStores)
            {
                if (store.storeName.Contains(sortStoreName))  // Условная конструкция проверяет совпадает ли название магазина с названием, которое ввел пользователем в аргументе
                {
                    FindSoresToNames.Add(store);
                    countMassive.Add(count);
                }
                count++;
            }

            return FindSoresToNames;

        }


        static void Main()
        {
            Console.SetWindowSize(125, 30);
            string productName = null;
            string storeName = null;
            float costOfGoods = 0;
            int numberLiteralInAlphabet;
            string language = null;
            int count = 1;
            int countCursor = 0;
            string sortStoreName = null;
            
            List<Price> Mycollection = new List<Price>();
            Console.WriteLine("Product data:".ToUpper().PadLeft(30));
            while (Mycollection.Count < 2)
            {
                Console.CursorLeft = 2;
                Console.WriteLine(new string('-', 55));
                Console.CursorLeft = 2;
                Console.Write("The name of the {0}st goods: ", count);
                productName = Console.ReadLine();
                Console.CursorLeft = 2;
                Console.Write("Store name: ");
                storeName = Console.ReadLine();
                Console.CursorLeft = 2;
                Console.Write("The price of {0}st goods: ", count++);
                costOfGoods = Convert.ToSingle(Console.ReadLine());
                language = LanguageDefinition(storeName);
                numberLiteralInAlphabet = IndexLiterals(storeName[0], language);
                Mycollection.Add(new Price(productName, storeName, costOfGoods, numberLiteralInAlphabet));
                Console.CursorLeft = 2;
                Console.WriteLine(new string('-', 55));
            }

            count = 1;

            List<Price> SortCollection = SortStoreToName(Mycollection);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorTop = countCursor++;
            Console.CursorLeft = 65;
            Console.WriteLine("List of stores alphabetically:".ToUpper().PadLeft(40));
            foreach (Price element in SortCollection)
            {
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine(new string('-', 55));
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("The name of the {0}st goods: {1}", count, element.productName);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("Store name: {0}", element.storeName);
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.WriteLine("The price of {0}st goods: {1}", count++, element.costOfGoods);
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

            while (true)
            {
                List<int> countMassive = new List<int>();
                Console.CursorTop = countCursor++;
                Console.CursorLeft = 65;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter store name to search: ".ToUpper());
                sortStoreName = Console.ReadLine();
                List<Price> findStore = FindStoreToName(SortCollection, sortStoreName, ref countMassive);
                count = 1;
                if (findStore.Count == 0)
                {
                    // Конструкция try-catch-finally для обработки исключений
                    try   // Обработка програмного исключения в случае неправильного ввода названия магазина в списке товаров
                    {
                        throw new MyException();  // Оператор throw генерирует экземпляр пользовательского исключения по слабой ссылке и далее передает его в блок catch в качестве входящего аргумента
                    }
                    catch (MyException e)  // Оператор catch принимает в качестве параметра из блока try сгенерированный экземпляр исключения типа FormatException
                    {
                        Console.CursorTop = countCursor;
                        Console.CursorLeft = 65;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    countCursor++;
                    continue;
                }
                countMassive.Reverse();

                foreach (Price element in findStore)
                {
                    Console.CursorTop = countCursor++;
                    Console.CursorLeft = 65;
                    Console.WriteLine(new string('-', 55));
                    Console.CursorTop = countCursor++;
                    Console.CursorLeft = 65;
                    Console.WriteLine("The name of the {0}st goods: {1}", countMassive[findStore.Count - count], element.productName);
                    Console.CursorTop = countCursor++;
                    Console.CursorLeft = 65;
                    Console.WriteLine("Store name: {0}", element.storeName);
                    Console.CursorTop = countCursor++;
                    Console.CursorLeft = 65;
                    Console.WriteLine("The price of {0}st goods: {1}", countMassive[findStore.Count - count++], element.costOfGoods);
                    Console.CursorTop = countCursor++;
                    Console.CursorLeft = 65;
                    Console.WriteLine(new string('-', 55));
                    
                    Thread.Sleep(50);
                }
            }
        }
    }
}
