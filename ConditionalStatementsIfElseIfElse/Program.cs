using System;

namespace ConditionalStatementsIfElseIfElse
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            /*
              * expression is a condition
              * if the condition is true then instruction (true) will be executed
              * IF (condition)
              * instruction;
              * IF otherwise (condition)
              * instruction;
              * TOTALLY otherwise if the previous conditions have not been met
              * instruction;
             * */
            int a = 5, b = 5;

            if (a < b)
            { //begin
                Console.WriteLine("a < b");
                Console.WriteLine("you got here first and won something ;)");
            } //end;
            else if (a > b)
                Console.WriteLine("a > b");
            else
            {
                Console.WriteLine("a == b");
                Console.WriteLine("a is equal to b");
            }


            if (((5 > 7) && (7 > 4)) || (10 == 10))
                Console.WriteLine("((5 > 7) && (7 > 4)) || (10 == 10) returns the truth");


            /*
              * if (condition)
              * instruction;
              *
              * if (condition)
              * instruction;
              * else
              * instruction2;
              *
              * if (condition)
              * instruction;
              * else if (condition2)
              * instruction2;
              * else
              * instruction3;
              *
              * if (condition)
              * instruction;
              * else if (condition2)
              * instruction2;
              * else if (condition3)
              * instruction3;
              * ....
              *
              *
              * if (condition)
              * {
              * // ANY OPERATIONS
              * if (condition2)
              * {
              * // some operations that affect condition3 again
              * if (condition3)
              * instruction;
              *}
              *}
              *
              *
              *
             * */

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
                a = 10;

                if (a > b)
                    Console.WriteLine("a has been changed and is now greater than b");
                else if (a < b)
                    Console.WriteLine("a has been changed and is now less than b");
                else
                    Console.WriteLine("a is still equal b");
            }
            Console.ReadLine(); 
        }
    }
}