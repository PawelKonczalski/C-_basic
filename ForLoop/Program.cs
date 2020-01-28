using System;

namespace ForLoop
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            /*
             * for (int i = 0; i < 10; i++)
              * INSTRUCTIONS
              *
              * for (INITIALIZATION OF VARIABLES; CONDITION; WHAT IS TO BE PERFORMED AFTER EACH LOOP CIRCUIT)
              * INSTRUCTIONS
              *
             * */

            for (int i = 0; i < 3;  i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine(); 
        }
    }
}