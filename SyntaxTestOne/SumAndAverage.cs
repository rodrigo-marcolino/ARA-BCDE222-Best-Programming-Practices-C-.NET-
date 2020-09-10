using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SyntaxTestOne
{
    class SumAndAverage
    {
        public double Sum;
        public double Average;
        protected int Min;
        protected int Max;


        public SumAndAverage(int min, int max)
        {
            Min = min;
            Max = max;
        }
        public void Calculate()
        {
            CalculateSum();
            CalculateAverage();
        }

        private void CalculateSum()
        {
            Sum = 0.0;
            for (int i = Min; i < Max; i++)
            {
                Sum += i;
            }
        }

        private void CalculateAverage()
        {
            int n = Max - Min + 1;
            Average = Sum / n;
        }
    }
}   
