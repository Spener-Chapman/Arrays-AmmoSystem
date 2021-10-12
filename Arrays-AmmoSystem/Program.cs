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
        static string name;


        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine(name);
            Console.WriteLine(weaponName[weapon] + ": " + ammo[weapon] + "/" + maxAmmo[weapon]);
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }

        static void FireWeapon()
        {
            //0 = revolver
            //1 = shotgun
            //2 = machine gun
            //3 = sniper

            ammo[weapon] = ammo[weapon] - 1;
            if (ammo[weapon] <= 0)
            {
                Console.WriteLine("Reload");
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
            name = "Musu";

            // fake gamplay to show arrays and ammo

            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();
            ShowHUD();
            Reload();
            ShowHUD();

            weapon = 1;

            ShowHUD();
            FireWeapon();
            ShowHUD();

            weapon = 2;
            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();
            ShowHUD();
            FireWeapon();

            weapon = 1;

            ShowHUD();
            FireWeapon();
            ShowHUD();
            Reload();
            ShowHUD();

            weapon = 3;
            ShowHUD();
            FireWeapon();
            ShowHUD();

            weapon = 2;
            ShowHUD();

            weapon = 0;
            ShowHUD();





            Console.ReadKey(true);

        }
    }
}
