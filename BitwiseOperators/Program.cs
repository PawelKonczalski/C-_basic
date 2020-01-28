using System;

namespace BitwiseOperators
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
                        
            /*
             * 0 - false
             * 1 - true
             * 
             * 1 2 6 = 1 * 10 ^ 2 + 2 * 10 ^ 1 + 6 * 10 ^ 0 = 100 + 20 + 6 = 126
             * 
             * 1 0 1 0 = 0 * 2 ^ 0 + 1 * 2 ^ 1 + 0 * 2 ^ 2 + 1 * 2 ^ 3 = 0 + 2 + 0 + 8 = 10
             * 
             * 1 0 1 0 = 8 + 2 = 10
             * 
             * */

            /* conjunctions - &
             * 1 0 1 0
             * 0 0 1 0
             * -------
             * 0 0 1 0
             * */
            Console.WriteLine(10 & 2);

            /* alternative - |
             * 1 0 1 0
             * 0 0 1 0
             * -------
             * 1 0 1 0
             * */
            Console.WriteLine(10 | 2);

            /* EXCLUSIVE ALTERNATIVE (XOR) - ^ 
             * 1 0 1 0
             * 0 0 1 0
             * -------           wyr1 wyr2 result
             * 1 0 0 0            0     0    0
             *                    0     1    1
             *                    1     0    1
             *                    1     1    0
             * */
            Console.WriteLine(10 ^ 2);

            /*
             * ~ - negation
             * 
             * ~(1 0 1 0) = (0 1 0 1)
             * */
            Console.WriteLine(~10);

            /*
             *  10 << 1
             *  0 0 0 0 0 0 0 1 0 1 0 (8 + 2)
             *  0 0 0 0 0 0 1 0 1 0 0 (8 + 2) * 2 = (8 * 2 + 2 * 2) = (20)
             *  10 >> 1
             *  0 0 0 0 0 0 0 1 0 1 0 (8 + 2)
             *  0 0 0 0 0 0 0 0 1 0 1 (8 + 2) / 2 = (4 + 1) = 5
             * */

            Console.WriteLine(10 << 3);
            Console.WriteLine(10 >> 1);
            Console.ReadLine(); 
        }
    }
}