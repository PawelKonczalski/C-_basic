using System;

namespace SwitchConditionalStatements
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string countryName = "US";
           
            switch (countryName)
            {
                case "PL":
                    Console.WriteLine("You are from Poland :)");
                    break;
                case "EN":
                case "US":   
                case "UK":
                    Console.WriteLine("You speak English");
                    break;
                    
                default:
                    Console.WriteLine("I don't know what language you speak ;)");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}