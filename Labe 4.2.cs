namespace Labe_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text");
            string str = Console.ReadLine();
           

            int count = 0;

            foreach (int c in str )
            {
                if (c == ' ')
                {
                    count++;
                }
            }
           
            Console.WriteLine("(2)Amount gap:" + count);
        }
    }
}