using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    /*Задание
Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. 
Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;   // При чтении: смена кодировки языка в "Unicode" для правильного отображения строковых литералов на украинский язык в консоли
            Console.InputEncoding = Encoding.Default;    // При записи: смена кодировки языка в "Unicode" для правильного отображения строковых литералов на украинский язык в консоли
            Console.WriteLine(string.Format("Dictionary".ToUpper()));
            Console.WriteLine(new string('-', 30));
            Dictionary dictionary = new Dictionary();
           
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(dictionary[i]);
                }
           
            Console.WriteLine(new string('-', 30));
           Again:
            
                Console.Write("Enter the word: ");
                string word = Console.ReadLine();
                Console.Write("Select the target language: ");
                string translate = Console.ReadLine();
            
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(dictionary[word, translate]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            goto Again;


        }
    }
}
