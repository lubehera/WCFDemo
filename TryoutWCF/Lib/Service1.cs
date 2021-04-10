using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lib
{
    public class CalculatorService : ICalculator
    {
        public double Add(double n1, double n2)
        {
            double result = n1 + n2;

            Console.WriteLine($"Received Add({n1}, {n2})");
            Console.WriteLine($"Return : {result}");

            return result;
        }

        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;

            Console.WriteLine($"Received Divide({n1}, {n2})");
            Console.WriteLine($"Return : {result}");

            return result;
        }

        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;

            Console.WriteLine($"Received Multiply({n1}, {n2})");
            Console.WriteLine($"Return : {result}");

            return result;
        }

        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;

            Console.WriteLine($"Received Subtract({n1}, {n2})");
            Console.WriteLine($"Return : {result}");

            return result;
        }
    }
}
