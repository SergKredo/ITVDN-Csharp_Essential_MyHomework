using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который
позволит сохранять заметки читателя.*/
    class Book
    {
        public string text = " День начинает заметно прибавляться ещё с половины декабря; а к 9-му марта он займёт уже половину суток. Начало весны потому и считается с 9-го марта. Солнце весною не только дольше остаётся на небе, но и греет с каждым днём заметно сильнее. Снег начинает мало - помалу таять, и вода ручейками сбегает с земли в реки и озёра. Скоро и лёд на реках уступает влиянию лучей солнца. По берегам рек появляются большие полыньи. Пройдёт ещё с неделю — и весь лёд подымется прибывающей водою, почернеет, начнёт ломаться, и рыхлые льдины понесутся по течению реки. Воды в реке в это время прибывает столько, что она не может поместиться в берегах: выступает и разливается по окрестным лугам. Разлив рек зовут водопольем. Иная речонка такая маленькая, что летом ее переходили вброд, в водополье разливается на пять, на шесть вёрст и более. Наша Волга-матушка, в которую вливаются тысячи рек и речонок, расстилается весною словно море. Люди спешат воспользоваться недолгим богатством воды, и большие барки, нагруженные товарами, ходят весною там, где летом чуть не бродят куры. На полях появляются сначала проталины: но скоро земля, мокрая, пропитанная водою, повсюду показывается из-под снега. Пройдёт ещё неделя, другая — и снег останется разве где - нибудь в глубоком овраге, куда не заглядывает солнце. Небо становится всё синее, а воздух всё теплее. Ещё не весь снег сойдёт, когда там и сям начнёт уже показываться, возле старой пожелтевшей травы, новая, ярко-зелёная травка. На полях, где крестьяне ещё с осени засеяли рожь или пшеницу, подымается и зеленеет озимь, словно зелёный бархат. ";

        public class Notes : Book
        {
            public void FindNext(string str)
            {
                FindAndReplaceManager.sampletext = text;
                FindAndReplaceManager.Note.FindNext(str);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Book.Notes name = new Book.Notes();
            Console.Write(new string('-', 120));
            string headline = "Заметки в тексте:";
            headline = headline.PadLeft(70);
            Console.WriteLine(headline.ToUpper());
            Console.Write(new string('-', 120) + "\n");
            Console.WriteLine("Выбранный Вами текст:\n\n{0}", name.text);
            Console.Write(new string('-', 120));
        Again:
            Console.Write("\nВведите пожалуйста слово возле которого стоит поставить заметку: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string find = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(new string('-', 120));
            if (string.IsNullOrEmpty(find))
            {
                Console.WriteLine("Вы не ввели слово! Повторите пожалуйста эту операцию заново!");
                Console.Write(new string('-', 120));
                goto Again;
            }
            Console.WriteLine("Вывод в тексте заданного слова. Напишите пожалуйста рядом свою заметку!\n");
            Console.WriteLine(new string('-', 120));
            name.FindNext(find);
            Console.WriteLine("\n");
            Console.Write(new string('*', 120));
            Console.Write(new string('*', 120));
            Console.Write(new string('-', 120));
            goto Again;
        }
    }
}
