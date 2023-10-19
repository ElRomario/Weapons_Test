using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWorkWeapons
{
    class SniperRifle : Weapon
    {
        public override int Damage { get { return 50; } }
        public override double Interval { get { return 4; } }

        public override void Fire()
        {
            Console.WriteLine("Sniper rifle fired!");
        }
    }
}
