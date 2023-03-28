namespace Labe_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read Text");
            string input =Console.ReadLine();
            int lower= 0;
            int upper= 0;
            foreach (char text in input)
            {
                if (char.IsLower(text))
                {
                    lower++;
                }
                else if (char.IsUpper(text))
                {
                    upper++;
                }
            

            }
            float ProcentLower = (float)lower/input.Length * 100;
            float ProcentUpper = (float)upper/input.Length * 100;

            Console.WriteLine("percentage of lowercase letters" + ProcentLower + "%");
            Console.WriteLine("percentage of uppercase letters" + ProcentUpper + "%");
        }
    }
}