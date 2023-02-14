namespace Net_Crash_2023_lab__Enums__circle
{
    internal class Program
    {
        enum circle {perimeter = 1,radius , area}

        

        static void Main(string[] args)
        {
            
            double D = 2 ;
            //Console.Write($"Enter the amount of currency ");
            //double UAH = double.Parse(Console.ReadLine());


            Console.WriteLine(" perimeter = 1 , radius = 2  , area = 3 ");
            Console.Write("Select the currency to be converted  ");
            int circle = int.Parse(Console.ReadLine());

            switch (circle)
            {
                case 1:
                    

                    double L = Math.PI* D;
                    Console.WriteLine($"{L}");
                    break;
                case 2:
                    

                    double R = D /2  ;
                    Console.WriteLine($"{R}");
                    break;
                case 3:
                    

                    double S = (Math.PI * D*D)/4;
                    Console.WriteLine($"{S}");
                    break;


                default: Console.WriteLine("Invalid direction"); break;

            }
        }
    }
}
