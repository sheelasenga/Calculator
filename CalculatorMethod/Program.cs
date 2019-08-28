using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMethod;

namespace CalculatorMethod
{
  
        class program
        {
            static void Main(string[] args)
            {

            calculatorMethod cal = new calculatorMethod();
                Console.WriteLine(cal.Add(2, 2));
            Console.WriteLine(cal.Subtract(2, 2));
            Console.WriteLine(cal.Divide(2, 2));
            Console.WriteLine(cal.Multiply(2, 2));
        
        Console.ReadLine();
            }
        }

    }
