using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{


    //Func<int, int> factorial = n => n == 0 ? 1 : 
    //Enumerable.Range(1, n).Aggregate((acc, x) => acc * x);



    //Func<int, int> factorial = null; 
    //factorial = x => x <= 1 ? 1 : x * factorial(x-1);
    //int numberInt = int.Parse(factorialNumberTextBox.Text);
    //factorialAnswerTextBox.Text = factorial(numberInt).ToString();


    public class RecursiveFactorial : IFactorial
    {
        public BigInteger Calculate(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Calculate(n - 1);
            }
        }
    }
}
