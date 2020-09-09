using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxTestTwo
{
    class CalculationController
    {
        private readonly IView View;
        private readonly Calculator Calculator;

        public CalculationController(IView view, Calculator calculator)
        {
            View = view;
            Calculator = calculator;
        }
        public void Go()
        {
            int n;
            View.Begin();
            n = Int32.Parse(View.Read("Enter the stop number"));
            View.Show("Sum of odd nunbers within 1 to {0}", n);
            for (int i = 1; i <= n; i++) {
                View.Show("sum of odds from 1 to {0} = {1}", i, Calculator.Calculate(1, i));
            }
            View.End();
        }
    }
}
