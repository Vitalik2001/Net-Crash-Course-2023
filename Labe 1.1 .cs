namespace labe__1._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task!. The user enters the current date");
            System.Console.Write("Year: ");
            if (!short.TryParse(System.Console.ReadLine(), out short year))
            {
                System.Console.Write("Invalid value of year, Try again: ");
            }

            System.Console.Write("Month: ");
            if (!byte.TryParse(System.Console.ReadLine(), out byte month))
            {
                System.Console.Write("Invalid value of month. Try again: ");
            }

            System.Console.Write("Day: ");
            if (!byte.TryParse(System.Console.ReadLine(), out byte day))
            {
                System.Console.Write("Invalid value of day. Try again: ");
            }

            if (!DateTime.TryParse($"{year}.{month}.{day}", out DateTime now))
            {
                System.Console.Write($"{now.ToString()} is not a correct date");
            }
            System.Console.WriteLine(now.ToString("dd.MM.yyyy"));
        }
    }
}