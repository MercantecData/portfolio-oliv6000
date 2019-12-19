using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Projektuge_Opgave_SPIL
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
        private int default_energy;
        public int energy;
        private int default_Armor;
        public int armor;
        private int default_Evasiveness;
        public int evasiveness;
        public int critical_Chance;
        public string equiped_Equipment;

        public Player(string name)
        {
            this.name = name;
            level = 1;
            exp = 0;
            default_Damage = 10;
            default_Health = 30;
            default_energy = 100;
            default_Armor = 0;
            default_Evasiveness = 0;
        }

        public void startup_Stats()
        {
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Health: " + default_Health);
            Console.WriteLine("Damage: " + default_Damage);
            Console.WriteLine("Armor: " + default_Armor);
            Console.WriteLine("Evasiveness: " + default_Evasiveness);
            Console.WriteLine("======================================");
        }

        public void update_Stats(Equipment equipment)
        {
            equiped_Equipment = equipment.name;
            health = equipment.health_Buff + (default_Health * (level * 0.85));
            damage = default_Damage * level;
        }


    }
}
