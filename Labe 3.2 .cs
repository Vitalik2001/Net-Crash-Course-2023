namespace Labe_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Job 2 --------------------");
            //string a = Console.ReadLine()!;
            Random random = new Random();
            int b = random.Next(1, 10);
            int counter = 0;
            while (true)
            {
                Console.Write("Guess the number: ");
                int guess = int.Parse(Console.ReadLine());
                counter++;

                if (guess == b)
                {
                    Console.WriteLine("You got it! The number was {0}.", b);
                    Console.WriteLine("It took you {0} attempts to guess the number.", counter);
                    break;
                }
                else if (guess < b)
                {
                    Console.WriteLine("The number is higher.");
                }
                else
                {
                    Console.WriteLine("The number is lower.");
                }
            }
        }
    }
}