
using System;

namespace AP02023_hw00_Welcome
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a+b;
        }

        public static string GetMessage()
        {
            return "Welcome";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }
    }
}

