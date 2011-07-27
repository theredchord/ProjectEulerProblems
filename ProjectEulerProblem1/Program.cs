using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            NaturalNumbers numbers = new NaturalNumbers();
            var finalSum = numbers.naturalNumbers();
            Console.WriteLine(finalSum);    //Answer: 233168
        }
    }
}
