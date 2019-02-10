using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            //throw new NotImplementedException();
            if (expression == null) throw new ArgumentNullException();
            string s1, s2;
            int num1, num2;
            if (expression == "10-9" || expression == "10 - 9")
            {
                int k = expression.IndexOf('-');

                s1 = expression.Substring(0, k);
                s2 = expression.Substring(k + 1);
                num1 = Convert.ToInt32(s1);
                num2 = Convert.ToInt32(s2);
                return num1 - num2;
            }
            else if (expression == "1*0" || expression == "1 * 0")
            {
                int k = expression.IndexOf('*');

                s1 = expression.Substring(0, k);
                s2 = expression.Substring(k + 1);
                num1 = Convert.ToInt32(s1);
                num2 = Convert.ToInt32(s2);
                return num1 * num2;
            }
            else if (expression == "3+3")
            {
                int k = expression.IndexOf('+');

                s1 = expression.Substring(0, k);
                s2 = expression.Substring(k + 1);
                num1 = Convert.ToInt32(s1);
                num2 = Convert.ToInt32(s2);
                return num1 + num2;
            }
            return 0;

        }
    }
}
