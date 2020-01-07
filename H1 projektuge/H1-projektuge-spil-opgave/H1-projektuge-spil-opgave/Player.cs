using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_projektuge_spil_opgave
{
    class Player
    {
        public string name;
        public int level;
        public double exp;
        private int default_Damage;
        public int damage;
        private double default_Health;
        public double health;
        private double default_Armor;
        public double armor;
        public double equipment_Health;
        public string equiped_Weapon;
        public string equiped_Equipment;


        public Player(string name)
        {
            this.name = name;
            level = 1;
            exp = 0;
            default_Damage = 15;
            default_Health = 50;
            default_Armor = 5;
        }

        public void Initiating_Stats(Player player)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Level: " + player.level);
            Console.WriteLine("Health: " + player.default_Health);
            Console.WriteLine("Damage: " + player.default_Damage);
            Console.WriteLine("Armor: " + player.default_Armor);
            Console.WriteLine("======================================");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress any key to continue!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey();
        }
        public void setup_Stats(Player player)
        {
            player.health = default_Health;
            player.damage = default_Damage;
            player.armor = default_Armor;
        }
        public void update_Stats_With_Equipment(Equipment_Set equipment, Player player)
        {
            player.equipment_Health = equipment.health_Buff;
            player.equiped_Equipment = equipment.name;
            player.health = (equipment.health_Buff + (default_Health * (level * 0.85)));
            player.armor = equipment.armor_Buff + (default_Armor * (level * 0.85));
        }
        public void merchant_Healing(Player player)
        {
            player.health = equipment_Health + (default_Health * (level * 0.85));
        }
        public void level_Up(Player player)
        {
            player.health = equipment_Health + (default_Health * (level * 0.85));
        }
        public void update_Stats_With_Weapon(Weapon weapon, Player player)
        {
            player.equiped_Weapon = weapon.name;
            player.damage = default_Damage + weapon.damage_Buff;
        }
        public void show_Stats(Player player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(player.name + "'s ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("stats--->\n==========================");

            Console.WriteLine("Level: " + player.level + "\nHealth: " + player.health + "\nDamage: " + player.damage + "\nArmor: " + player.armor);

            Console.WriteLine("==========================\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to continue!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }


    }
}
