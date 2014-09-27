using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleSum
{
    public class SumOfSquaresService
    {
        public long SumOfSquares(IEnumerable<int> range)
        {
            long sum = 0;
            foreach (int rangeElement in range)
            {
                sum += rangeElement * rangeElement;
            }
            return sum;
        }
    }
}
