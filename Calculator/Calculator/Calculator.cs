using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class Calculator
    {
        public static double Calculate(double num1, double num2, string operation)
        {
            switch(operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "×":
                    return num1 * num2;
                case "÷":
                    return num1 / num2;
                default:
                    return 0;
            }

        }
    }
}
