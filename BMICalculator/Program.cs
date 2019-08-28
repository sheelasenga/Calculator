using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight (kg):");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Height (cm):");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine("BMI:" + Math.Round(BMI, 2));
            Console.ReadKey();
        }
    }
}
