namespace Labe_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerationAbbr("value, result, string"));
        }
        
            static string GenerationAbbr(string str)
            {
                string[] words = str.Split(' ');
                string abbreviation = "";
                foreach (string word in words)
                {
                    abbreviation += word[0];
                }
                return abbreviation.ToUpper();
            }
        }
    }
