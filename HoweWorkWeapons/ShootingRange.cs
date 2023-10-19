using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWorkWeapons
{
    class ShootingRange
    {
        static int HP = 100;
        static bool pow = false;
        int shots = 0;
        public void weaponTest(Weapon weapon)
        
        {
            while (HP > 0)
            {
                System.Console.Clear();

                Console.WriteLine($"Weapon: {weapon.GetType().Name}");
                Console.WriteLine($"Fire rate:{weapon.Interval}");
                Console.WriteLine($"Damage Per Second:{weapon.Damage}");
                Console.WriteLine("==========================");

                HP -= weapon.Damage;
                shots++;
                pow = !pow;

                if (pow)
                {  Console.WriteLine("POW!"); }
                else { Console.WriteLine(" "); };

                Console.WriteLine($"Stand Health Points: {HP}");
                System.Threading.Thread.Sleep((int)(weapon.Interval * 1000));

            }

            Console.WriteLine("Test Report:");
            Console.WriteLine($"It took {shots} to kill with ");
        }
       
    }
}
