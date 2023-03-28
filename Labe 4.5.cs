namespace Label_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text ");
            string input = Console.ReadLine();
            string result = "";
            while (input.EndsWith("."))
            {
                result += input + ",";
                input = Console.ReadLine();
            }
            result += input.TrimEnd('.');
            Console.WriteLine("Result:  " + result);
        }
    }
}