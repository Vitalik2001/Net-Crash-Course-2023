namespace Net_Crash_1_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("First task!. The user enters the current date");
            Console.Write($"enter the hour ");
            string hour =Console.ReadLine();
            Console.Write($"enter the year ");
            string year = Console.ReadLine();
            Console.Write($"enter the month ");
            string month = Console.ReadLine();
            Console.WriteLine($"Result:{hour}/{month}/{year}");//Користувач вводить поточну дату (рік, місяць, день)
           
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
            



            Console.WriteLine($"\nThe fourth task!. The user enters the time in seconds, display it in the form: HH:MM:SS.");

            Console.Write("Year: ");
            if (!ushort.TryParse(Console.ReadLine(), out ushort year))
            {
                Console.Write("Invalid value. Try again: ");
            }

            if (year % 4 == 0)
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