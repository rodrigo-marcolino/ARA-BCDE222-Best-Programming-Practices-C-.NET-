using System;

namespace SyntaxTestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new SumAndAverageController(new ConsoleView());
            controller.Go();
        }
    }
}
