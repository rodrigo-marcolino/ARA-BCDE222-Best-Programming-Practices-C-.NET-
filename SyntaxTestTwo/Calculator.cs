using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxTestTwo
{
    class Calculator
    {
        public double Calculate(int minimum, int maximum)
        {
            double sum = 0.0;
            for (int i = minimum; i <= maximum; i++) {
                if (IsOdd(i)) {
                    sum += i;
                }
            }
            return sum;
        }
        public bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
    }
}
