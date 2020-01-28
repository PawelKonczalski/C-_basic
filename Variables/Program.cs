using System;

namespace Variables
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            /*
             * LICZBY CAŁKOWITE - INTEGER
             * sbyte - -128 do 127, na 8 bit, 1 bajcie
             * short - -32.768 do 32.767, na 16 bit, 2 bajtach
             * int - ~-2mld do +2 mld, na 32 bit, 4 bajtach
             * long - -2^63 do 2^63-1, na 64 bit, 8 bajtów
             * 
             * byte - 0 do 255, na 8 bitach
             * ushort (u - unsigned) - 0 do 65.535
             * uint - 0 do 2^32-1
             * ulong - 0 do 2^64-1   
             * 
             * LICZBY ZMIENNOPRZECINKOWE - FLOATING-POINT Types
             * 
             * float 7 znaków po przecinku - 1,5 * 10 ^-45 do 3.4 * 10 ^38 - 32 bitach
             * double od 15 do 16 - 5 * 10 ^ -324 do 1.7 * 10 ^ 308
             * 
             * decimal 28 znaków po przecinku od 1 * 10 ^ - 28 do 7.9 * 10 ^ 28 - 128 bitach
             * 
             * BOOLEAN - true lub false 
             * 
             * TYP ZNAKOWY
             * 
             * char 
             * 
             * TYP CIĄGU ZNAKÓW - STRING
             * 
             * */

            float lz1 = 2.1458761F;
            double lz2 = 6.14524849416;
            decimal lz3 = 5.125874698452321485632M;

            const bool check = 2 > 5;
            
            Console.WriteLine("This is: " + check);
        }
    }
}