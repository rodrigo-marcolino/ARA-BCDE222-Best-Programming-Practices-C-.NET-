using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxTestOne
{
    class ConsoleView : IView
    {
        public void Display<T>(string message, T value)
        {
            Console.WriteLine(message, value);
        }

        public void Display<T>(T mesage)
        {
            Console.WriteLine(mesage);
        }

        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void Start()
        {
            Console.Clear();
        }

        public void Stop()
        {
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
