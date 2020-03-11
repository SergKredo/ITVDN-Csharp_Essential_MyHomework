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

namespace Additional_Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }
        public EventHandler someEvent = null;     // Объявляем открытый делегат типа EventHandler
        public event EventHandler SomeEvent       // Создаем событие типа делегат класса EventHandler
        {
            add { someEvent += value; }           // Метод доступа к событию (подписывает методы -обработчики событий к делегату)
            
            remove { someEvent -= value; }        // Метод доступа к событию (отписывает методы -обработчики событий от делегата)
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)       // Метод-обработчик события Click (событие происходит в момент нажатия на кнопки Botton на интерфейсе программы)
        {
            presenter.Invoke(sender, e);                                  // Вызываем на объекте presenter метод Invoke
        }
    }
}
