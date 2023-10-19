﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWorkWeapons
{
    class AutomaticRifle : Weapon
    {
        public override int Damage { get { return 25; } }
        public override double Interval { get { return 0.5; } }

        public override void Fire()
        {
            Console.WriteLine("Auto rifle fired!");
        }
    }
}
