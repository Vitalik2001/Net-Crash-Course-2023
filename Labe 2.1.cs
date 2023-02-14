namespace Net_Crash_2023_lab__Enums_
{
    internal class Program
    {
       enum day { Monday = 1 , Tuesday = 2 , Wednesday = 3, Thursday = 4, Friday= 5, Saturday = 6, Sunday = 7 }
        static void Main(string[] args)
        {
            Console.WriteLine("select the day of the week by number");
            Console.WriteLine("Monday = 1 , Tuesday = 2 , Wednesday = 3, Thursday = 4, Friday= 5, Saturday = 6, Sunday = 7 ");
            Console.Write("You select day   ");
           int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine(" Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Invalid direction"); break;

            }


            //Console.WriteLine("Good Bye");
        }
    }
}