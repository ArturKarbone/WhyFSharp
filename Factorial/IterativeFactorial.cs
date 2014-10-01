using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class IterativeFactorial : Factorial.IFactorial
    {
        public BigInteger Calculate(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
