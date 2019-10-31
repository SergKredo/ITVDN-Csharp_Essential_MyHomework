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
    class User
    {
        string login;
        string name;
        string surname;
        string old;
        public string Login
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public string Surname
        {
            get;set;
        }
        public string Old
        {
            get; set;
        }
        readonly string dataForm;

        public User(string dataForm)
        {
            this.dataForm = dataForm;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Information about client:");
            Console.WriteLine("Login: {0}", Login);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Old: {0}", Old);
            Console.WriteLine("DataForm: {0}", dataForm);
        }
    }
}
