using System;
using System.Transactions;

namespace Net_Crahs_2023_labe_3__Array
{
    internal class Program
    {
        //enum Rand { amount = 1, sort , even_values, Max}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a given");
            char given = Console.ReadLine()[0];

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Output ");
            foreach (int i in Enumerable.Range(0, number))
            {
                Console.WriteLine(given);
            }


        }
    }
}