using System;

namespace WhileAndDoWhileLoops
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int i = 5;
            /*
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
            */
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 3);
            
            Console.ReadLine();  
        }
    }
}