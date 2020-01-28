using System;

namespace ConditionalOperator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            // (CONDITION)? when the condition is true (true): when the condition is not true (false);

            string test = (a > b) ? "a is greater than b" : "a is smaller than b, or equal to b";

            
            //Console.WriteLine(test);
            Console.WriteLine(((a > b) ? a : b) + 100);
            

            Console.ReadLine();
        }
    }
}