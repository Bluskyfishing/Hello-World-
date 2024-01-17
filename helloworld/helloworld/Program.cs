using System;
using System.Diagnostics.Metrics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isak");
            CountTo(11);
        }
        static void CountTo(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}