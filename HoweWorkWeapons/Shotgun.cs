using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWorkWeapons
{
    class Shotgun : Weapon
    {
        public override int Damage {get {return 20;} }
        public override double Interval { get { return 2; } }

        public override void Fire()
        {
            Console.WriteLine("Shotgun Fired!");
        }

    }
}
