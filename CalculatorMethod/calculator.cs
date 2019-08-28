using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMethod;

namespace CalculatorMethod
{
   public class calculatorMethod
    {
    
            private double total;
            public calculatorMethod()
            {
                total = 0;
            }
            public double Add(double num1, double num2)
            {

                return num1 + num2;
            }

            public int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }

            
            public int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }

            
            public int Divide(int num1, int num2)
            {
                return num1 / num2;

            }
        }
}
