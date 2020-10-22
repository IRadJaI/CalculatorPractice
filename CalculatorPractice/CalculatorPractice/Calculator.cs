using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorPractice
{
    public static class Calculator
    {
        public static int Plus(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }

        public static int Minus(string a, string b)
        {
            return Convert.ToInt32(a) - Convert.ToInt32(b);
        }

        public static int Multiply(string a, string b)
        {
            return Convert.ToInt32(a) * Convert.ToInt32(b);
        }

        public static float Devide(string a, string b)
        {
            return float.Parse(a) / float.Parse(b);
        }
    }
}
