using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Controls;

namespace StopWatch_Task3_
{
    

    class Presenter
    {

        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();

            this.mainWindow.EventStart += EventStart;  //Подписывание метода-обработчика EventStart на событие this.mainWindow.EventStart
            this.mainWindow.EventReset += EventReset;  //Подписывание метода-обработчика EventReset на событие this.mainWindow.EventReset
        }

        private void EventReset(object sender, EventArgs e)   // Метод-обработчик, который позволяет обнулить значение таймера (обнуляет значения данных в компонентах Label)
        {
            this.mainWindow.Miliseconds.Content = "00";
            this.mainWindow.Seconds.Content = "00.";
            this.mainWindow.Minuts.Content = "00:";
            this.mainWindow.Hours.Content = "00:";
            this.mainWindow.Days.Content = "00:";
        }


        private void EventStart(object sender, EventArgs e)  // Метод-обработчик, который запускает отсчет таймера  (в компонентах Label)
        {
            if (Convert.ToInt32(this.mainWindow.Miliseconds.Content) != 59)
            {
                this.mainWindow.Miliseconds.Content = this.model.AddNumber(this.mainWindow.Miliseconds.Content.ToString());
            }
            else if (Convert.ToInt32(this.mainWindow.Seconds.Content.ToString().Remove(2)) != 59)
            {
                this.mainWindow.Miliseconds.Content = "00";
                this.mainWindow.Seconds.Content = this.mainWindow.Seconds.Content.ToString().Remove(2);
                this.mainWindow.Seconds.Content = this.model.AddNumber(this.mainWindow.Seconds.Content.ToString());
                this.mainWindow.Seconds.Content += ".";
            }
            else if (Convert.ToInt32(this.mainWindow.Minuts.Content.ToString().Remove(2)) != 59)
            {
                this.mainWindow.Miliseconds.Content = "00";
                this.mainWindow.Seconds.Content = "00.";
                this.mainWindow.Minuts.Content = this.mainWindow.Minuts.Content.ToString().Remove(2);
                this.mainWindow.Minuts.Content = this.model.AddNumber(this.mainWindow.Minuts.Content.ToString());
                this.mainWindow.Minuts.Content += ":";
            }
            else if (Convert.ToInt32(this.mainWindow.Hours.Content.ToString().Remove(2)) != 59)
            {
                this.mainWindow.Miliseconds.Content = "00";
                this.mainWindow.Seconds.Content = "00.";
                this.mainWindow.Minuts.Content = "00:";
                this.mainWindow.Hours.Content = this.mainWindow.Hours.Content.ToString().Remove(2);
                this.mainWindow.Hours.Content = this.model.AddNumber(this.mainWindow.Hours.Content.ToString());
                this.mainWindow.Hours.Content += ":";
            }
            else
            {
                this.mainWindow.Miliseconds.Content = "00";
                this.mainWindow.Seconds.Content = "00.";
                this.mainWindow.Minuts.Content = "00:";
                this.mainWindow.Hours.Content = "00:";
                this.mainWindow.Days.Content = this.mainWindow.Days.Content.ToString().Remove(2);
                this.mainWindow.Days.Content = this.model.AddNumber(this.mainWindow.Days.Content.ToString());
                this.mainWindow.Days.Content += ":";
            }
        }
    }
}
