using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem2
{
    class Fibonacci
    {
        public List<int> finalList = new List<int>();
        public int fibMax = 4000000;

        public int FibGenerator(int i)
        {
            int fibVal = 0;
            if (i > 1)
            {
                while (fibVal < fibMax)
                {
                    fibVal = FibGenerator(i - 2) + FibGenerator(i - 1);
                    return fibVal;
                }
            }
            return i;
        }

        public List<int> FibonacciList()
        {
            List<int> fibList = new List<int>();
            for (int i = 0; i < fibMax; i++)
            {
                fibList.Add(FibGenerator(i));
            }
            return fibList;
        }

        public int FibonacciFilter(List<int> fibList)
        {
            foreach (var item in fibList)
            {
                if (item % 2 == 0)
                {
                    finalList.Add(item);
                }
            }
            return finalList.Sum();
        }
    }
}
