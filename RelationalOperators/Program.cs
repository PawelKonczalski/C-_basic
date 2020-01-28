using System;

namespace RelationalOperators
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            bool a = true;

            int zm1 = 4, zm2 = 5;

            Console.WriteLine(zm1 >= zm2);
            /*
            * == - will return true if and only if the elements are equal!
            * != - will return true if the elements are uneven
            * a > b - returns true if element a is larger than element b
            * a < b - returns true if element a is smaller than element b
            * a <= b - returns true if element a is less than or equal to element b
            * a >= b - returns true if element a is greater than or equal to element b
            * */
            Console.ReadLine();
        }
    }
}