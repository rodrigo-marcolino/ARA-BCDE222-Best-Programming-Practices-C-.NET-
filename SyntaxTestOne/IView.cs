using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxTestOne
{
    interface IView
    {
        string GetInput(string prompt);
        void Display<T>(string message, T value);
        void Display<T>(T mesage);
        void Start();
        void Stop();
    }
}
