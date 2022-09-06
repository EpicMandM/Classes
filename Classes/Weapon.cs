using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class Weapon
    {
        private string weaponType;
        private string weaponKind;

        public string WeaponType { get => weaponType; set => weaponType = value; }
        public string WeaponKind { get => weaponKind; set => weaponKind = value; }
        public virtual int Ammo { get; set; }

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
        public void AddAmmo(int count) => Ammo += count;
    }
    class M590 : Weapon
    {
        public override int Ammo { get => base.Ammo; 
            set {
                    base.Ammo = value;
                if (base.Ammo < 0)
                {
                    Console.WriteLine("Out of ammo!");
                    Ammo = default;
                }

            } 
        }
        public M590(int ammo) : base("Shotgun", "Combat weapon", ammo)
        {

        }
        public override void Shoot()
        {
            Ammo--;
            Console.WriteLine("Shotgun has shot!");
        }
    }
}
