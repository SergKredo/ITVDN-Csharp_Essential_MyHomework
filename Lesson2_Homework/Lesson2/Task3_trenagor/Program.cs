using System;

namespace Less02_task02
{
    /*В классе MyClass реализуйте метод IsLuckyTicket, который должен принимать на вход строковое представление шестизначного номера лотерейного билета,
        и возвращать значение, является ли он «счастливым» - то есть, равна ли сумма первых трех цифр сумме остальных трех. Например: “123006” – счастливый,
        а “345123” – нет. На любую некорректную входную строку метод должен возвращать значение false. */
    class Program
    {
        static void Main(string[] args)
        {
            Again:
            Console.Write("Введите пожалуйста любое шестизначное натуральное число: ");
            string ticket = Console.ReadLine();
            Console.WriteLine("Выиграшь в лотерею возможен при условии, что суммы значений\nпервой и второй половины шестизначного числа равны между собою!");
            MyClass luckyTicket = new MyClass();
            if (luckyTicket.IsLuckyTicket(ticket) != true)
            {
                Console.WriteLine("\n");
                goto Again;
            }

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public bool IsLuckyTicket(string ticket)
        {
            int sum1 = 0;
            int sum2 = 0;
            int number;
            for (int i = 0; i < ticket.Length - 3; i++)
            {
                sum1 += Convert.ToInt32(ticket[i]);
            }
            for (int i = 3; i < ticket.Length; i++)
            {
                sum2 += Convert.ToInt32(ticket[i]);
            }
            if (sum1 == sum2 && ticket.Length == 6 && Int32.TryParse(ticket, out number))
            {
                Console.WriteLine("Поздравляем с выиграшем! Ты счастливчик!");
                return true;
            }
            else if (sum1 != sum2 && ticket.Length == 6 && Int32.TryParse(ticket, out number))
            {
                Console.WriteLine("Возможно в следующий раз тебе обязательно повезет! Попробуй еще раз!");
                return false;
            }
            Console.WriteLine("Вы ввели не шестизначное число! Попробуйте пожалуйста еще раз!");
            return false;
        }
    }
}


