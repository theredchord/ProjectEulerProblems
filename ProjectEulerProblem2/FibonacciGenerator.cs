using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem2
{
    class FibonacciGenerator
    {
        public List<int> Generator()
        {
            int maxValue = 4000000;
            int fibValue = 0;
            List<int> fibValues = new List<int>();

            for (int i = 0; fibValue < maxValue; i++)
            {
                fibValue = FibNumbers(i);
                fibValues.Add(fibValue);
            }
            return fibValues;
        }

        public int FibFilter(List<int> filterList)
        {
            List<int> fibEven = new List<int>();
            int fibSum = 0;

            foreach (var item in filterList)
            {
                if (item % 2 == 0)
                {
                    fibEven.Add(item);
                }    
            }
            fibSum = fibEven.Sum();
            return fibSum;
        }

        public int FibNumbers(int x)
        {
            if (x > 1)
            {
                return FibNumbers(x - 2) + FibNumbers(x - 1);
            }
            return 1;
        }
    }
}
