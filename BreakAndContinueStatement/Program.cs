using System;

namespace BreakAndContinueStatement
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            /*
             * 1 2 3 4 5 6 7 8 9 10
             * 2 4 6 8 10 12 14 16 18 20
             * 3 6 9 12 15 18 21 24 27 30
             * 
             * */
            /*
            for (int i = 1; i <= 10; i++) //number of rows, column length
            {
                
                if (i == 3)
                    continue; // what is after CONTINUE is not done, but the loop is still CONTINUED
                
                if (i == 3)
                    break; // what is after break; IS NOT PERFORMED, we leave the nearest LOOP

                for (int j = 1; j <= 10; j++) //number of columns, row length
                {
                    if (j == 3)
                    continue;
                    Console.Write(i * j + " ");
                }

                Console.WriteLine();
            }
        */

            for (int i = 1, j = 1; i <= 10; i++)
            {
                Console.Write(i * j + " ");
                if (i == 10)
                {
                    i = 0;
                    j++;
                    Console.WriteLine();
                }
                if (j == 10 + 1)
                    break;
            }

            Console.ReadLine(); 
        }
    }
}