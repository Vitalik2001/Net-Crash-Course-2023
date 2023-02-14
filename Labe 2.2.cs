using System.Diagnostics;

namespace Net_Crash_2023_lab__Enums__convector
{
    internal class Program
    {
        enum money { USD = 1, EUR = 2, PLN = 3}
        static void Main(string[] args)
        {
            Console.Write($"Enter the amount of currency ");
            double UAH= double.Parse(Console.ReadLine());
            
            
            Console.WriteLine(" USD = 1, EUR = 2, PLN = 3");
            Console.Write("Select the currency to be converted  ");
            int money = int.Parse(Console.ReadLine());

            switch (money)
            {
                case 1:
                    double USD = 40.28;

                    double ConUSD = UAH / USD;
                    Console.WriteLine($"{ConUSD}");
                    break;
                case 2:
                    double EUR = 41.28;

                    double ConEUR = UAH / EUR;
                    Console.WriteLine($"{ConEUR}");
                    break;
                case 3:
                    double PLN = 8.15;

                    double ConPLN = UAH / PLN;
                    Console.WriteLine($"{ConPLN}");
                    break;
               
               
                default: Console.WriteLine("Invalid direction"); break;

            }
        }
    }
}