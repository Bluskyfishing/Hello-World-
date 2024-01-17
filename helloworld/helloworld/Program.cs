using System;
using System.Diagnostics.Metrics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isak"); //prints name 
            CountTo(11); // counts to 10 from 1 
        }
        static void CountTo(int num)
        {
            for (int i = 1; i < num; i++) // changed to 1 instead of 0, to avoid 0 print. 
            {
                Console.WriteLine(i);
            }
        }
    }
}