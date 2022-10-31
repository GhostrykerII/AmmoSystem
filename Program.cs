using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmoSystem
{
    internal class Program
    {
        static int[] MaxAmmo;
        static int[] Ammo;
        static int weapon;
        static string[] WeaponName;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Weapon Ammo System ===");
            Console.WriteLine();

            Ammo = new int[5];
            Ammo[0] = 14;
            Ammo[1] = 19;
            Ammo[2] = 18;
            Ammo[3] = 35;
            Ammo[4] = 5;

            MaxAmmo = new int[5];
            MaxAmmo[0] = 15;
            MaxAmmo[1] = 30;
            MaxAmmo[2] = 45;
            MaxAmmo[3] = 80;
            MaxAmmo[4] = 8;


            WeaponName = new string[5];
            WeaponName[0] = "Pistol";
            WeaponName[1] = "SMG";
            WeaponName[2] = "AR";
            WeaponName[3] = "LMG";
            WeaponName[4] = "Shotgun";

            weapon = 3;

            weaponAmmoCheck();
            Console.ReadKey();

            Fire(20);
            weaponAmmoCheck();
            Console.ReadKey(true);

            Reload();
            weaponAmmoCheck();
            Console.ReadKey(true);


            weapon = 2;

            weaponAmmoCheck();
            Console.ReadKey();

            Fire(10);
            weaponAmmoCheck();
            Console.ReadKey(true);

            Reload();
            weaponAmmoCheck();
            Console.ReadKey(true);
        }


        static void weaponAmmoCheck()
        {
            Console.WriteLine("Weapon: " + WeaponName[weapon] + " Ammo: " + Ammo[weapon]);
            Console.WriteLine();
        }


        static void Fire(int bulletsShot)
        {
            Console.WriteLine("You are about to use a " + WeaponName[weapon] + ", and fire " + bulletsShot + " Shots");
            Ammo[weapon] = Ammo[weapon] - bulletsShot;
            Console.WriteLine("You shot " + WeaponName[weapon] + " " + bulletsShot + " Times!");
            Console.WriteLine();
        }

        static void AmmoCheck()
        {
            if (Ammo[weapon] == 0)
            {
                Console.WriteLine(WeaponName + " Mag is empty!" +  " Ammo: " + (Ammo[weapon] = 0));
                Console.WriteLine();
            }
        }

        static void Reload()
        {
            Ammo[weapon] = Ammo[weapon] + MaxAmmo[weapon];


            if (Ammo[weapon] > MaxAmmo[weapon])
            {
                Ammo[weapon] = MaxAmmo[weapon];
                Console.WriteLine("Reload " + WeaponName[weapon] + "Ammo: " + Ammo[weapon]);
            }
        }



    }
}
