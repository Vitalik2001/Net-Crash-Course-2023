namespace Net_Crash_2023_labe_4__string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text:");
            string str = Console.ReadLine();
            //Console.WriteLine(str);
            
            char[] revers = str.ToCharArray();
            Array.Reverse(revers);

            str = new string(revers);

            Console.WriteLine($"(1)In reverse order: \n{str}");

            
           
            //Console.WriteLine($"Index of Gap: {str.IndexOf(' ')}");
            
        }
    }
}