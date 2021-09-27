using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapons = new List<Weapon>();

            var item = new Weapon(1, "霸王枪", 100);
            weapons.Add(item);

            weapons.Add(new Weapon(2, "长剑", 60));
            weapons.Add(new Weapon(3, "匕首", 40));
            weapons.Add(new Weapon(4, "盾牌", 0));
            foreach (var iWeapon in weapons)
            {
                Console.WriteLine(iWeapon);
            }

            Console.WriteLine("--------------------");
            weapons.RemoveAt(1);
            foreach (var iWeapon in weapons)
            {
                Console.WriteLine(iWeapon);
            }
            
            
            
            Console.WriteLine("--------------------");
            foreach (var iWeapon in weapons)
            {
                if (iWeapon.Name == "盾牌")
                {
                    weapons.Remove(iWeapon);
                    break;
                }
            }
            foreach (var iWeapon in weapons)
            {
                Console.WriteLine(iWeapon);
            }
            
            Console.WriteLine("--------------------");
            foreach (var iWeapon in weapons)
            {
                if (iWeapon.Name == "匕首")
                {
                    iWeapon.Attack = 99999;
                    // break;
                }
            }
            foreach (var iWeapon in weapons)
            {
                Console.WriteLine(iWeapon);
            }
        }
    }
}