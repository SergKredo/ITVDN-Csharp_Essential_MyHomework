using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Model
    {
        public string Addition(string s1, string s2)
        {
            double number1 = Convert.ToDouble(s1);
            double number2 = Convert.ToDouble(s2);
            double result = number1 + number2;
            string r = Convert.ToString(result);
            return r;
        }
        public string Subtraction(string s1, string s2)
        {
            double number1 = Convert.ToDouble(s1);
            double number2 = Convert.ToDouble(s2);
            double result = number1 - number2;
            string r = Convert.ToString(result);
            return r;
        }
        public string Multiplication(string s1, string s2)
        {
            double number1 = Convert.ToDouble(s1);
            double number2 = Convert.ToDouble(s2);
            double result = number1 * number2;
            string r = Convert.ToString(result);
            return r;
        }
        public string Division(string s1, string s2)
        {
            double number1 = Convert.ToDouble(s1);
            double number2 = Convert.ToDouble(s2);
            if (number2 == 0)
            {
                return null;
            }
            else
            {
                double result = number1 / number2;
                string r = Convert.ToString(result);
                return r;
            }
        }
        public string Dropping(string s1, string s2)
        {
            return null;
        }

    }
}
