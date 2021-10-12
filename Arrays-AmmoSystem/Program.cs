using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_AmmoSystem
{
    class Program
    {
        static int[] ammo;
        static int[] maxAmmo;
        static string[] weaponName;
        static int weapon;
       

        static void FireWeapon()
        {
            //0 = revolver
            //1 = shotgun
            //2 = machine gun
            //3 = sniper

            ammo[weapon] = ammo[weapon] - 1;
            if (ammo[weapon] <= 0)
            {
                Console.WriteLine("You're out of ammo!");
                ammo[weapon] = 0;
            }
        }

        static void Reload()
        {
            //0 = revolver
            //1 = shotgun
            //2 = machine gun
            //3 = sniper

            ammo[weapon] = maxAmmo[weapon];
        }

        static void Main(string[] args)
        {
            ammo = new int[4];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 50;
            ammo[3] = 10;

            maxAmmo = new int[4];
            maxAmmo[0] = 6;
            maxAmmo[1] = 2;
            maxAmmo[2] = 50;
            maxAmmo[3] = 10;

            weaponName = new string[4];
            weaponName[0] = "Revolver";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Machine Gun";
            weaponName[3] = "Sniper";

            weapon = 0;

            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            FireWeapon();
            Console.WriteLine(ammo[weapon]);
            Reload();
            Console.WriteLine(ammo[weapon]);

            Console.ReadKey(true);

        }
    }
}
