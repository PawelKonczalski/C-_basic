using System;

namespace LogicalOperators
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine( ((12 > 7) && (9 > 4)) && (4 != 4));
            Console.WriteLine(!((5 == 5) || (4 == 2)));


            /*             
             * ampersand
             * conjunction - && - conjunction is true if BOTH expressions are true
             * TRUE
             * FALSE
             * (wyr1) && (wyr2)
             * 
             * wyr1 wyr2   result
             * true true   true
             * true false  false
             * false true  false
             * false false false
             * 
             * or - || - the alternative is false only if BOTH expressions are false
             * 
             * wyr1 wyr2 result
             * true true true
             * true false true
             * false true true
             * false false false
             * 
             * Denied - negation
             * ! 
             * !(true) result is false
             * !(false) result is true
             * */

            Console.ReadLine(); 
        }
    }
}