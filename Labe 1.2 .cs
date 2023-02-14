namespace Labe_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nSecond task!. The user enter two sides of a rectangle");
            Console.WriteLine($"enter the two sides of the rectangle");
            int a = 6;
            int b = 12;
            int S = a * b;
            Console.WriteLine($"{a} * {b} = {S}");
            int P = a * 2 + b * 2;
            Console.WriteLine($"{a} * 2  + {b} * 2 = {P}");
            Console.WriteLine($"Result: perimeter of the rectangle: {P} square of the rectangle: {S}");
        }
    }
}