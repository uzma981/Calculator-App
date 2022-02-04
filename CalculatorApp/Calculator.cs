using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public static class Calculator
    {

        public static int Add(int x, int y)
        {
            int num1 = x;
            int num2 = y;
            int answer = num1 + num2;
            return answer;
        }
        public static int Minus(int x, int y)
        {
            int num1 = x;
            int num2 = y;
            int answer = num1 - num2;
            return answer;
        }

        public static int Multiply(int x, int y)
        {
            int num1 = x;
            int num2 = y;
            int answer = num1 * num2;
            return answer;
        }

        public static int Divide(int x, int y)
        {
            int num1 = x;
            int num2 = y;
            int answer = num1 / num2;
            return answer;
        }

    }
}
