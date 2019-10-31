using System;

namespace Additional_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Экземпляр класса Printer: id = {0}\n", printer.GetHashCode());

            printer.Print("Human");
            Console.WriteLine("id - Human: {0}\n", printer.GetHashCode());
            DirevedPrinter direvedPrinter = new DirevedPrinter();
            printer = direvedPrinter;
            direvedPrinter = (DirevedPrinter)printer;
            direvedPrinter.Print("Human with coat");
            Console.WriteLine("id - Human with coat: {0}", printer.GetHashCode());
            Console.ReadKey();
        }
    }
}
