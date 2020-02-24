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

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public event EventHandler eventResult = null;
        public event EventHandler eventAddition = null;
        public event EventHandler eventDropping = null;
        public event EventHandler eventSubtraction = null;
        public event EventHandler eventMultiplication = null;
        public event EventHandler eventDivision = null;
        public event EventHandler eventFocus = null;

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            eventResult.Invoke(sender, e);
        }
        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            eventAddition.Invoke(sender, e);
        }
        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            eventSubtraction.Invoke(sender, e);
        }
        private void ButtonClick4(object sender, RoutedEventArgs e)
        {
            eventMultiplication.Invoke(sender, e);
        }
        private void ButtonClick5(object sender, RoutedEventArgs e)
        {
            eventDivision.Invoke(sender, e);
        }

        private void ButtonClick6(object sender, RoutedEventArgs e)
        {
            eventDropping.Invoke(sender, e);
        }

        private void TextBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EventFocus(object sender, RoutedEventArgs e)
        {
            eventFocus.Invoke(sender, e);
        }

        private void BeginnerKey(object sender, KeyEventArgs e)
        {
            eventFocus.Invoke(sender, e);
        }
    }
}
