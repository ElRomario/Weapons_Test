using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWorkWeapons
{
    class Pistol : Weapon
    {
        public override int Damage { get { return 10; } }
        public override double Interval { get { return 1; } }

        public override void Fire()
        {
            Console.WriteLine("Pistol fired!");
        }
    }
}
