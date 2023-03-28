using System.ComponentModel;

namespace Net_Crash_2023_labe_5__OOP
{

    class Weapon
    {
        enum typeOfShooting { fuse, singleShooting, shootingInTurn }
        string model;
        int year; 
        int range;
        int Shope; // 20
        int maxSizeShope; // 30
        float AfterShot;
        double caliber;
        bool isShotOn;
        typeOfShooting Shoting;

        public void Initialaze(string m, int y, int s, double k)
        {
            
            model = m;
            year = y;
            Shope = s;
            caliber = k;
            AfterShot = Shope;
            maxSizeShope = 30;
            range = 400;
            isShotOn = false;
            Shoting = typeOfShooting.shootingInTurn;
        }
        public void SwitchShot()
        {
            if (Shoting == typeOfShooting.fuse)
            {

                isShotOn = false;
            }
            else
            {
                if (Shoting == typeOfShooting.singleShooting)
                {
                    isShotOn = true;
                }
                if (Shoting == typeOfShooting.shootingInTurn)
                {
                    isShotOn = true;
                }

                //if(Shoting==)
            }
        }
        public bool Shot()
        {
            /* if (Shope > 0)
             {
                 AfterShot--;
                 Console.WriteLine("Shot fired!");
                 return true;
             }
             else
             {
                 Console.WriteLine("Empty magazine!");
                 return false;
             }*/
            
            if (Shoting == typeOfShooting.fuse)
            {
                
                    AfterShot -= 0;
                Console.WriteLine("check (stands on the fuse)");
            }
            else
            {
                if(Shoting == typeOfShooting.singleShooting)
                {
                    if(AfterShot > 0)
                    AfterShot -= 1;
                    Console.WriteLine("single shot!");
                }
                if(Shoting == typeOfShooting.shootingInTurn)
                {
                    if (AfterShot > 0)
                        AfterShot -= 5;
                    Console.WriteLine("burst shooting!");
                }

                //if(Shoting==)
            }



            return false;
        }
        public void Recharge()
        {
            if(AfterShot < maxSizeShope)
            AfterShot += 1;
            /*if (AfterShot > maxSizeShope)
            {
                AfterShot -= 1;
                Console.WriteLine("the store is full");
            }*/
        }
        public void ShowInfo ()
        {
            Console.WriteLine($"Model: {model} , year: {year} range of fire {range} cartridges in the shop {Shope} Max Size shope: {maxSizeShope} cartridge caliber: {caliber}\n" +

                
                $"Shope weapon: {Shope} -> {AfterShot} <- {maxSizeShope}\n" +
                $"Shooting status: {(isShotOn ? "ON" : "OFF")}  ");

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Weapon my = new Weapon();

            my.Initialaze("Ak- 74 ", 1999, 10,  5.45);
            //my.Shot();
            //my.SwitchShot();
            for (int i= 0; i < 1; i++)
            {
                my.Shot();
                //my.Recharge();
            }
            my.ShowInfo();
            
            Weapon you = new Weapon();

            you.Initialaze("M4a1 ", 2009, 20, 5.45);
            //my.Shot();
            //you.SwitchShot();
            for (int i = 0; i < 3; i++)
            {
                you.Shot();
                //my.Recharge();
            }
            you.ShowInfo();
            

        }
    }
}