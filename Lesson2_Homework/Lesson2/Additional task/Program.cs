using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе.*/
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User("24.09.2019")
            {
                Login = "Serg",
                Name = "Sergey",
                Old = "27 years",
                Surname = "Kredentser"
            };

            person.DisplayInformation();
            

            Console.ReadKey();
        }
    }
}
