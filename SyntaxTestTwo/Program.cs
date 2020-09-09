using System;

namespace SyntaxTestTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            new CalculationController(new ConsoleView(), new Calculator()).Go();
        }
    }
}
