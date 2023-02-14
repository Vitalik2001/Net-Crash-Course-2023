namespace Labe_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nThe third task!. The user enters the radius of the circle");

            Console.Write("Enter radius");
            double r = 12;
            double π = 3.14;

            double PK = π * r;
            Console.WriteLine($"{π} * {r} = {PK}");
            Console.WriteLine($"Result: radius of the circle ={PK} ");

            
        }
    }
}