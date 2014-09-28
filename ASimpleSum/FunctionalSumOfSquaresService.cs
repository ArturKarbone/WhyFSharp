using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleSum
{
    public class FunctionalSumOfSquaresService
    {
        public long SumOfSquares(IEnumerable<int> range)
        {
            return range
                .Select(x => x * x)
                .Sum();
        }

        public long SumOfSquares2(IEnumerable<int> range)
        {
            return range
                .Sum(x => x * x);
        }
    }
}
