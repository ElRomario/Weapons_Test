using System;



namespace HoweWorkWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Pistol pistol = new Pistol();
            Shotgun shotgun = new Shotgun();
            SniperRifle sniper = new SniperRifle();
            AutomaticRifle autoRifle = new AutomaticRifle();
            ShootingRange range = new ShootingRange();

            int input;

            Console.WriteLine("Welcome to Shooting Range!");
            Console.WriteLine("==========================");
            Console.WriteLine("Choose gun to shoot: ");
            Console.WriteLine("1 - Pistol");
            Console.WriteLine("2 - Sniper rifle");
            Console.WriteLine("3 - Automatic rifle");
            Console.WriteLine("4 - Shotgun");
            Console.WriteLine("Any onther key - exit");
            Console.WriteLine("==========================");
            Console.Write("Input: ");
            input = Int32.Parse(Console.ReadLine());

            switch(input)
            {
                case 1: range.weaponTest(pistol); break;
                case 2: range.weaponTest(sniper); break;
                case 3: range.weaponTest(autoRifle); break;
                case 4: range.weaponTest(shotgun); break;
                default: return;
            }


        }
    }
}
