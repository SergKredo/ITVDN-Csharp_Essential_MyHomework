using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Additional_Task
{
    class Model
    {

        // Метод, который задает особый функционал в зависимости от нажатой кнопки Botton в программе
        public string Button1_Text(string s, string sender)
        {
            switch (sender)
            {
                case "Button1":
                    {
                        return s + " Hi!";
                    }
                case "Button2":
                    {
                        return s + " Good morning!";
                    }
                case "Button3":
                    {
                        return s + " Congratulations!";
                    }
                case "Button4":
                    {
                        return s + " You're welcome!";
                    }
                case "Button5":
                    {
                        return s + " Wonderful!";
                    }
                default:
                    {
                        return s;
                    }
            }
            
        }
        

    }
}
