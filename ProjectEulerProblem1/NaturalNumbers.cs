using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem1
{
    class NaturalNumbers
    {
        //Create list to store numbers
        List<int> naturalList = new List<int>();

        //Add numbers below 1000 that are multiples of 3 or 5 (natural numbers)
        public int naturalNumbers()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    naturalList.Add(i);
                }
            }
            return naturalList.Sum();
        }
    }
}
