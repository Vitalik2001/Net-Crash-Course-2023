namespace Labe_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Job 3 --------------------");
            Random random1 = new Random();
            const int A = 20;

            var randomMassiv = new int[A];
            for (int i = 0; i < A; i++)
            {

                randomMassiv[i] = random1.Next(1, 100);


            }
            Console.WriteLine("randomMassiv with random numbers:");
            foreach (int num in randomMassiv)
            {
                Console.Write(num + " ");
            }


            int[] numbers = new int[20];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
        }
    }
}