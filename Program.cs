namespace Net_Crash_1_lab
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
        

        Console.WriteLine ($"\nSecond task!. The user enter two sides of a rectangle");
            Console.WriteLine ($"enter the two sides of the rectangle");
            int a = 6;
            int b = 12;
            int S = a * b;
            Console.WriteLine($"{a} * {b} = {S}");
            int P = a * 2 + b *2;
            Console.WriteLine($"{a} * 2  + {b} * 2 = {P}");
            Console.WriteLine($"Result: perimeter of the rectangle: {P} square of the rectangle: {S}");


            Console.WriteLine($"\nThe third task!. The user enters the radius of the circle");

            Console.Write("Enter radius");
            double r = 12;
            double π = 3.14;

            double PK =  π * r;
            Console.WriteLine($"{π} * {r} = {PK}");
            Console.WriteLine($"Result: radius of the circle ={PK} ");

            Console.WriteLine($"\nThe fourth task!. The user enters the time in seconds, display it in the form: HH:MM:SS.");

            int s = 9123;
            Console.WriteLine(TimeSpan.FromSeconds(s));
            



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