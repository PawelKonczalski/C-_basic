using System;

namespace ArithmeticAndAssignmentsOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 10, c;

            //a += 7; // a = a + 7
            //a -= 5; // a = a - 5

            a /= 3; // a = 7 / 3 = 2 (i 1 / 3) - this is removed because we operate on integers
            Console.WriteLine(a);


            // 23 % 10 = 2 i 3 / 10
            // 7 % 3 = 2 i 1 / 3
            
            /*
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " / " + b + " = " + (a / (double)b));
            Console.WriteLine(a + " * " + b + " = " + (a * b));

            Console.WriteLine(a + " % " + b + " = " + (a % b));
            */
            //post-increment
            /*
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(a);
            */

            //pre-increment
            /*
            Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.WriteLine(a);
            */
            //POSTDEKREMENTACJA

            /*
            Console.WriteLine(a--);
            Console.WriteLine(a);
            Console.WriteLine(a);
            */
            //PREDEKREMENTACJA
            /*
            Console.WriteLine(--a);
            Console.WriteLine(a);
            Console.WriteLine(a);
            */

            

            Console.ReadLine();  

        }
    }
}