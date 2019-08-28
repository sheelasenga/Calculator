using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Double num1;
            Double num2;
            double total;
            char funct;
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator");
            funct = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (funct == '+')
            {
                total = num1 + num2;
                Console.WriteLine("Total:" + total);
                Console.ReadLine();

            }
            else if (funct == '-')
            {
                total = num1 - num2;
                Console.WriteLine("Total:" + total);
                
            }
            else if (funct == '*')
            {
                total = num1 * num2;
                Console.WriteLine("Total:" + total);
                
            }
            else if (funct == '/')
            {
                total = num1 / num2;
                Console.WriteLine("Total:" + total);
                
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                Console.ReadLine();
            }
        }
    }
}
