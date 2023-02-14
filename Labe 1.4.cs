namespace Labe_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nThe fourth task!. The user enters the time in seconds, display it in the form: HH:MM:SS.");

            int s = 9021;
            Console.WriteLine(TimeSpan.FromSeconds(s));



        }
    }
}