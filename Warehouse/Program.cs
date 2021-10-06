using System;

namespace Warehouse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Warehouse App");
            Console.WriteLine("Please let me know what you would like to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Check Item");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();
            Console.WriteLine($"You have chosen option number: {choice}");
        }
    }
}