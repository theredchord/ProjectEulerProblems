using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();
            var fibList = fibonacciGenerator.Generator();
            var finalSum = fibonacciGenerator.FibFilter(fibList);
            Console.WriteLine("The final sum is: {0}", finalSum);
        }
    }
}
