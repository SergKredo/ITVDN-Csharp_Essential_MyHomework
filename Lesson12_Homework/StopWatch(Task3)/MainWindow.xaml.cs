using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace StopWatch_Task3_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string myobject;   // Название объектов-кнопок в таймере
        DispatcherTimer timer;  // Создание экземпляра класса DispatcherTimer, который отвечает за таймер (периодическое повторение определенных действий над элементами программы) и
                                //     обрабатывается в течение указанного интервала времени
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
            timer = new DispatcherTimer();  
            timer.Interval = TimeSpan.FromMilliseconds(0.001);  // Период времени между тактами (в 1 миллисекунду)
            timer.Tick += Timer_Tick; // Событие, которое возникает при истечении интервала таймера (повторно вызывает метод-обработчик).
        }

        public event EventHandler EventStart = null;  // Событие, которое происходит в момент нажатия на кнопку Start
        public event EventHandler EventReset = null;  // Событие, которое происходит в момент нажатия на кнопку Reset


        // Метод-обработчик события Tick, которое реализует функционал запуска, остановки, обнуления счета таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sender.GetType().Name != "DispatcherTimer")  
            { 
             myobject = ((Button)sender).Name; 
            }
            switch (myobject) // Проверка на нажатую кнопку
            {
                case "Start":
                    {
                        timer.Start();  // Метод, который запускает таймер (запускает System.Windows.Threading.DispatcherTimer)
                        EventStart.Invoke(sender, e);
                        break;
                    }
                case "Stop":
                    {
                        timer.Stop();  // Метод, который останавливает таймер (запускает System.Windows.Threading.DispatcherTimer)
                        break;
                    }
                case "Reset":
                    {
                        timer.Stop();
                        EventReset.Invoke(sender, e);
                        break;
                    }
                default:
                    {
                        timer.Stop();
                        break;
                    }
            }
        }
    }
}
