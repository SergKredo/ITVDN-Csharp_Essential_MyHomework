using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись?*/

    enum nameType
    { 
    one,
    two,
    three,
    four,
    five,
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayListStruct = new ArrayList();
            int count = 0;
            arrayListStruct.Add(1);   // В данной коллекции происходит операция упаковки из структурного и ссылочного типа к базовому типу object
            arrayListStruct.Add("name");
            arrayListStruct.Add(2);
            arrayListStruct.Add("hello");  
            arrayListStruct.Add(3.2f);
            arrayListStruct.Add("world");
            arrayListStruct.Add(400000m);
            arrayListStruct.Add("ITVDN");
            arrayListStruct.Add(5);
            arrayListStruct.Add("table");
            arrayListStruct.Add(6.55d);
            while (count != (int)nameType.five+1)   // Алгоритм сортировки элементов коллекции по типам
            {
                string nametype = null;
                switch (count)
                {
                    case (int)nameType.one:
                        {
                            Console.WriteLine("- System.Int32:".ToUpper());
                            nametype = "System.Int32";
                            break;
                        }
                    case (int)nameType.two:
                        {
                            Console.WriteLine("- System.String:".ToUpper());
                            nametype = "System.String";
                            break;
                        }
                    case (int)nameType.three:
                        {
                            Console.WriteLine("- System.Single:".ToUpper());
                            nametype = "System.Single";
                            break;
                        }
                    case (int)nameType.four:
                        {
                            Console.WriteLine("- System.Decimal:".ToUpper());
                            nametype = "System.Decimal";
                            break;
                        }
                    case (int)nameType.five:
                        {
                            Console.WriteLine("- System.Double:".ToUpper());
                            nametype = "System.Double";
                            break;
                        }
                }
 
                for (int i = 0; i < arrayListStruct.Count; i++)
                {
                    if (arrayListStruct[i].GetType().ToString() == nametype)
                        Console.WriteLine(arrayListStruct[i]);
                }
                Console.WriteLine(new string('-', 20));
                count++;
            }
            Console.ReadKey();
        }
    }
}
