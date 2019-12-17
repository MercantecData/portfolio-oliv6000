using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Projektuge_Opgave_SPIL
{
    class Player
    {
        public string name;
        public int level;
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

        public Player(string name)
        {
            this.name = name;
            level = 2;
            default_Damage = 10;
            default_Health = 30;
            default_energy = 100;
            default_Armor = 0;
            default_Evasiveness = 0;
        }

        public void player_Startup_Stats()
        {
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Evasiveness: " + evasiveness);
            Console.WriteLine("======================================");
        }

        public void set_Player_Stats()
        {
            health = default_Health * (level * 0.85);
            damage = default_Damage * level;
        }


    }
}
