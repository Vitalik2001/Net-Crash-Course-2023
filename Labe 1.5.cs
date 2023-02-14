namespace Label_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nThe fifth task!. The user enters the year, display how many days in this year.");

            Console.Write("Year: ");
            if (!ushort.TryParse(Console.ReadLine(), out ushort year1))
            {
                Console.Write("Invalid value. Try again: ");
            }

            if (year1 % 4 == 0)
            {
                Console.WriteLine(366);
            }
            else
            {
                Console.WriteLine(365);
            }


            Console.ReadKey();
        }
    }
}