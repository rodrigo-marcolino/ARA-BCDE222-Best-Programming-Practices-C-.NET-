using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxTestTwo
{
    class ConsoleView : IView
    {
        public void Begin()
        {
            Console.Clear();
        }

        public void End()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }

        public string Read(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void Show<T>(T message)
        {
            Console.WriteLine(message);
        }

        public void Show<T>(string message, T value)
        {
            Console.WriteLine(message, value);
        }

        public void Show<T>(string message, T value1, T value2)
        {
            Console.WriteLine(message, value1, value2);
        }
    }
}
