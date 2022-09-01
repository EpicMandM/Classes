using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class Weapon
    {
        public string WeaponType { get; set; }
        public string WeaponKind { get; set; }
        public int Ammo { get; set; }

        public Weapon(string weaponType, string weaponKind, int ammo)
        {
            WeaponType = weaponType;
            WeaponKind = weaponKind;
            Ammo = ammo;
        }

        public virtual void Shoot()
        {
            Ammo--;
        }
    }
    class M590 : Weapon
    {   
        public M590(int ammo) : base("Shotgun", "Combat weapon", ammo)
        {

        }
        public override void Shoot()
        {
            Ammo--;
            Console.WriteLine("Shotgun shoot!");
        }
    }
}
