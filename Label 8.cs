namespace Net_Crash_2023_labe_8_
{
    class Animal
    {
        public string Kind;
        public double Speed;
        public double Weight;
        public string LivingEnvironment;

        public void Move()
        {
            Console.WriteLine("The {0} is moving", Kind);
        }

        public void MakeSound()
        {
            Console.WriteLine("The {0} is making a sound\n", Kind);
        }

        public void Show()
        {
            Console.WriteLine("Kind: {0}\nSpeed: {1}\nWeight: {2}\nLiving Environment: {3}\n", Kind, Speed, Weight, LivingEnvironment);
        }
    }

    class Bird : Animal
    {
        public bool CanFly;
        public string BeakType;
    }

    class Reptile : Animal
    {
        public bool HasScales;
        public string Habitat;
    }

    class Fish : Animal
    {
        public bool HasFins;
        public string WaterType;
    }

    class Hawk : Bird
    {
        public Hawk()
        {
            Kind = "Hawk";
            Speed = 120;
            Weight = 10;
            LivingEnvironment = "Mountains";
            CanFly = true;
            BeakType = "Hooked";
        }
    }

    class Lizard : Reptile
    {
        public Lizard()
        {
            Kind = "monitor lizard";
            Speed = 30;
            Weight = 20;
            LivingEnvironment = "jungle";
            HasScales = true;
            Habitat = "Ground";
        }
    }

    class Dolphin : Fish
    {
        public Dolphin()
        {
            Kind = "Dolphin";
            Speed = 50;
            Weight = 3000;
            LivingEnvironment = "Ocean";
            HasFins = true;
            WaterType = "Saltwater";
        }
    }
    class Program
    {
        static void Main()
        {
            Animal[] zoo = new Animal[3];

            zoo[0] = new Hawk();
            zoo[1] = new Lizard();
            zoo[2] = new Dolphin();

            foreach (Animal animal in zoo)
            {
                animal.Show();
                animal.MakeSound();
                animal.Move();
            }
        }
    }
}