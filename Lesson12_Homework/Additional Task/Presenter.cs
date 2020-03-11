using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Additional_Task
{
    class Presenter
    {
        string myobject;
        readonly Model model;
        readonly MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();                 // Инстанцируем экземпляр объекта типа Model

            // Подписываем на событие SomeEvent все методы-обработчики события. У каждого метода-обработчика свой особый функционал
            this.mainWindow.SomeEvent += Button1Method;
            this.mainWindow.SomeEvent += Button2Method;
            this.mainWindow.SomeEvent += Button3Method;
            this.mainWindow.SomeEvent += Button4Method;
            this.mainWindow.SomeEvent += Button5Method;
        }
        public void Invoke(object sender, EventArgs e)
        {
            myobject = ((Button)sender).Name;   // Имя объекта (кнопки Botton), который вызывает событие SomeEvent
            switch (myobject)
            {
                case "Button1":  // Кнопка Botton1
                    {
                        // Отписываем от события SomeEvent ненужные методы-обработчики события
                        this.mainWindow.SomeEvent -= Button2Method;
                        this.mainWindow.SomeEvent -= Button3Method;
                        this.mainWindow.SomeEvent -= Button4Method;
                        this.mainWindow.SomeEvent -= Button5Method;
                        // Вызываем на классе-делегате метод связанный с данным делегатом (метод Button1Method())
                        this.mainWindow.someEvent.Invoke(sender, e);
                        // Заново подписываем на событие SomeEvent оставшиеся методы-обработчики события
                        this.mainWindow.SomeEvent += Button2Method;
                        this.mainWindow.SomeEvent += Button3Method;
                        this.mainWindow.SomeEvent += Button4Method;
                        this.mainWindow.SomeEvent += Button5Method;
                        break;
                    }
                case "Button2":   // Кнопка Botton2
                    {
                        // Отписываем от события SomeEvent ненужные методы-обработчики события
                        this.mainWindow.SomeEvent -= Button1Method;
                        this.mainWindow.SomeEvent -= Button3Method;
                        this.mainWindow.SomeEvent -= Button4Method;
                        this.mainWindow.SomeEvent -= Button5Method;
                        // Вызываем на классе-делегате метод связанный с данным делегатом (метод Button2Method())
                        this.mainWindow.someEvent.Invoke(sender, e);
                        // Заново подписываем на событие SomeEvent оставшиеся методы-обработчики события
                        this.mainWindow.SomeEvent += Button1Method;
                        this.mainWindow.SomeEvent += Button3Method;
                        this.mainWindow.SomeEvent += Button4Method;
                        this.mainWindow.SomeEvent += Button5Method;
                        break;
                    }
                case "Button3":  // Кнопка Botton3
                    {
                        // Отписываем от события SomeEvent ненужные методы-обработчики события
                        this.mainWindow.SomeEvent -= Button1Method;
                        this.mainWindow.SomeEvent -= Button2Method;
                        this.mainWindow.SomeEvent -= Button4Method;
                        this.mainWindow.SomeEvent -= Button5Method;
                        // Вызываем на классе-делегате метод связанный с данным делегатом (метод Button3Method())
                        this.mainWindow.someEvent.Invoke(sender, e);
                        // Заново подписываем на событие SomeEvent оставшиеся методы-обработчики события
                        this.mainWindow.SomeEvent += Button1Method;
                        this.mainWindow.SomeEvent += Button2Method;
                        this.mainWindow.SomeEvent += Button4Method;
                        this.mainWindow.SomeEvent += Button5Method;
                        break;
                    }
                case "Button4":  // Кнопка Botton4
                    {
                        // Отписываем от события SomeEvent ненужные методы-обработчики события
                        this.mainWindow.SomeEvent -= Button1Method;
                        this.mainWindow.SomeEvent -= Button2Method;
                        this.mainWindow.SomeEvent -= Button3Method;
                        this.mainWindow.SomeEvent -= Button5Method;
                        // Вызываем на классе-делегате метод связанный с данным делегатом (метод Button4Method())
                        this.mainWindow.someEvent.Invoke(sender, e);
                        // Заново подписываем на событие SomeEvent оставшиеся методы-обработчики события
                        this.mainWindow.SomeEvent += Button1Method;
                        this.mainWindow.SomeEvent += Button2Method;
                        this.mainWindow.SomeEvent += Button3Method;
                        this.mainWindow.SomeEvent += Button5Method;
                        break;
                    }
                case "Button5":  // Кнопка Botton5
                    {
                        // Отписываем от события SomeEvent ненужные методы-обработчики события
                        this.mainWindow.SomeEvent -= Button1Method;
                        this.mainWindow.SomeEvent -= Button2Method;
                        this.mainWindow.SomeEvent -= Button3Method;
                        this.mainWindow.SomeEvent -= Button4Method;
                        // Вызываем на классе-делегате метод связанный с данным делегатом (метод Button5Method())
                        this.mainWindow.someEvent.Invoke(sender, e);
                        // Заново подписываем на событие SomeEvent оставшиеся методы-обработчики события
                        this.mainWindow.SomeEvent += Button1Method;
                        this.mainWindow.SomeEvent += Button2Method;
                        this.mainWindow.SomeEvent += Button3Method;
                        this.mainWindow.SomeEvent += Button4Method;
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }
        
        // Методы-обработчики на событие SomeEvent
        private void Button1Method(object sender, EventArgs e)
        {
            myobject = ((Button)sender).Name;
            this.mainWindow.textBox1.Text = this.model.Button1_Text(this.mainWindow.textBox1.Text, myobject);
        }
        private void Button2Method(object sender, EventArgs e)
        {
            myobject = ((Button)sender).Name;
            this.mainWindow.textBox1.Text = this.model.Button1_Text(this.mainWindow.textBox1.Text, myobject);
        }
        private void Button3Method(object sender, EventArgs e)
        {
            myobject = ((Button)sender).Name;
            this.mainWindow.textBox1.Text = this.model.Button1_Text(this.mainWindow.textBox1.Text, myobject);
        }
        private void Button4Method(object sender, EventArgs e)
        {
            myobject = ((Button)sender).Name;
            this.mainWindow.textBox1.Text = this.model.Button1_Text(this.mainWindow.textBox1.Text, myobject);
        }
        private void Button5Method(object sender, EventArgs e)
        {
            myobject = ((Button)sender).Name;
            this.mainWindow.textBox1.Text = this.model.Button1_Text(this.mainWindow.textBox1.Text, myobject);
        }

    }
}
