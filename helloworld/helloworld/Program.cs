using System;
using System.Diagnostics.Metrics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isak"); //prints name 
            CountTo(11); // counts to 10 from 0 
        }
        static void CountTo(int num)
        {
            for (int i = 0; i < num; i++) // loops through argument.
            {
                Console.WriteLine(i);
            }
        }
    }
}