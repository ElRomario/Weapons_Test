using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWorkWeapons
{
    abstract class Weapon
    {
       public abstract int Damage { get; }
       public abstract double Interval { get; }

        public virtual void Fire()
        {
            Console.WriteLine("Weapon fired!");
        }


    }
}
