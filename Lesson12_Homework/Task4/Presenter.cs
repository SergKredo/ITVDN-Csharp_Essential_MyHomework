using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Presenter
    {
        int i = 0;
        int k = 0;
        Model model;
        MainWindow mainWindow;
        string number1, number2, number12, number21, number3;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.eventResult += MainWindow_Result;
            this.mainWindow.eventAddition += MainWindow_Addition;
            this.mainWindow.eventDropping += MainWindow_Dropping;
            this.mainWindow.eventSubtraction += MainWindow_Subtraction;
            this.mainWindow.eventMultiplication += MainWindow_Multiplication;
            this.mainWindow.eventDivision += MainWindow_Division;
            this.mainWindow.eventFocus += MainWindow_Focus;
        }

        private void MainWindow_Focus(object sender, EventArgs e)
        {
            if (k == 0)
            {
                this.mainWindow.TextBox1.Focus();
                this.mainWindow.TextBox1.SelectionStart = 1;
            }
            if (k == 1)
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text.Remove(0);
                this.mainWindow.TextBox1.SelectionStart = 1;
            }
            k++;
        }

        private void MainWindow_Division(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mainWindow.TextBox1.Text))
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else if (this.mainWindow.TextBox1.Text[this.mainWindow.TextBox1.Text.Length - 1] == '/')
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else
            {
                number1 = this.mainWindow.TextBox1.Text;
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text + "/";
                number12 = this.mainWindow.TextBox1.Text;
                number3 = number12.Substring(number12.IndexOf('/'), 1);
                i = 0;
            }
            this.mainWindow.TextBox1.Focus();
            this.mainWindow.TextBox1.SelectionStart = number12.Length;
        }

        private void MainWindow_Multiplication(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mainWindow.TextBox1.Text))
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else if (this.mainWindow.TextBox1.Text[this.mainWindow.TextBox1.Text.Length - 1] == '*')
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else
            {
                number1 = this.mainWindow.TextBox1.Text;
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text + "*";
                number12 = this.mainWindow.TextBox1.Text;
                number3 = number12.Substring(number12.IndexOf('*'), 1);
                i = 0;
            }
            this.mainWindow.TextBox1.Focus();
            this.mainWindow.TextBox1.SelectionStart = number12.Length;
        }

        private void MainWindow_Subtraction(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.mainWindow.TextBox1.Text))
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else if (this.mainWindow.TextBox1.Text[this.mainWindow.TextBox1.Text.Length - 1] == '-')
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else
            {
                number1 = this.mainWindow.TextBox1.Text;
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text + "-";
                number12 = this.mainWindow.TextBox1.Text;
                number3 = number12.Substring(number12.IndexOf('-'), 1);
                i = 0;
            }
            this.mainWindow.TextBox1.Focus();
            this.mainWindow.TextBox1.SelectionStart = number12.Length;
        }

        private void MainWindow_Dropping(object sender, EventArgs e)
        {
            this.mainWindow.TextBox1.Text = model.Dropping(number1, number2);
            number1 = null;
            number2 = null;
            number12 = null;
            number21 = null;
            number3 = null;
            this.mainWindow.TextBox1.Focus();
            this.mainWindow.TextBox1.SelectionStart = 1;
        }

        private void MainWindow_Result(object sender, EventArgs e)
        {
            number2 = this.mainWindow.TextBox1.Text;
            if (i++ == 0)
            {
                number2 = number2.Remove(0, number12.Length);
                number21 = number2;

            }
            else
            {
                number2 = number21;
            }
            switch (number3)
            {
                case "+":
                    {
                        this.mainWindow.TextBox1.Text = model.Addition(number1, number2);
                        break;
                    }

                case "-":
                    {
                        this.mainWindow.TextBox1.Text = model.Subtraction(number1, number2);
                        break;
                    }
                case "*":
                    {
                        this.mainWindow.TextBox1.Text = model.Multiplication(number1, number2);
                        break;
                    }
                case "/":
                    {
                        this.mainWindow.TextBox1.Text = model.Division(number1, number2);
                        break;
                    }
            }
            number1 = this.mainWindow.TextBox1.Text;
            this.mainWindow.TextBox1.Focus();
            this.mainWindow.TextBox1.SelectionStart = number1.Length;
        }
        private void MainWindow_Addition(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.mainWindow.TextBox1.Text))
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else if (this.mainWindow.TextBox1.Text[this.mainWindow.TextBox1.Text.Length - 1] == '+')
            {
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text;
            }
            else
            {
                number1 = this.mainWindow.TextBox1.Text;
                this.mainWindow.TextBox1.Text = this.mainWindow.TextBox1.Text + "+";
                number12 = this.mainWindow.TextBox1.Text;
                number3 = number12.Substring(number12.IndexOf('+'), 1);
                i = 0;
            }
            this.mainWindow.TextBox1.Focus();
            this.mainWindow.TextBox1.SelectionStart = number12.Length;

        }
    }
}
