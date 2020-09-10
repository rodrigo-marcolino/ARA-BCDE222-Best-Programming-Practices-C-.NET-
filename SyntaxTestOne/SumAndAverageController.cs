using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxTestOne
{
    class SumAndAverageController
    {
        private readonly IView View;
        private readonly SumAndAverage Calculator;

        public SumAndAverageController(IView view)
        {
            View = view;
            Calculator = new SumAndAverage(1, 100);
        }

        public void Go()
        {
            View.Start();
            Calculator.Calculate();
            View.Display("The sum is {0}", Calculator.Sum);
            View.Display("The avarage is {0:F1}", Calculator.Average);
            View.Stop();
        }
    }
}
