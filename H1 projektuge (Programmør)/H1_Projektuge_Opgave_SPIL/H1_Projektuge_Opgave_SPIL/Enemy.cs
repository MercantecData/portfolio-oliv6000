using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Projektuge_Opgave_SPIL
{
    class Enemy
    {
        public string name;
        public int default_Damage;
        public int damage;
        public double default_Health;
        public double health;
        public double armor;
        public double exp;
        private double default_Exp = 100;

        public Enemy()
        {

        }


        public void create_Enemy(Player player)
        {
            Random gettningRandomNumber = new Random();
            int randomEnemy = gettningRandomNumber.Next(1, 8);

            switch (randomEnemy)
            {
                case 1:
                    name = "Dasher";
                    default_Damage = 3;
                    default_Health = 20;
                    armor = 2 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.68);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.4);
                    break;
                case 2:
                    name = "Dancer";
                    default_Damage = 4;
                    default_Health = 30;
                    armor = 7 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.4);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.6);
                    break;
                case 3:
                    name = "Prancer";
                    default_Damage = 8;
                    default_Health = 15;
                    armor = 7 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.4);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.4);
                    break;
                case 4:
                    name = "Vixen";
                    default_Damage = 7;
                    default_Health = 25;
                    health = default_Health * (player.level * 0.46);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.8);
                    break;
                case 5:
                    name = "Comet";
                    default_Damage = 9;
                    default_Health = 10;
                    armor = 7 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.42);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.5);
                    break;
                case 6:
                    name = "Cupid";
                    default_Damage = 3;
                    default_Health = 50;
                    armor = 7 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.41);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.7);
                    break;
                case 7:
                    name = "Donner";
                    default_Damage = 2;
                    default_Health = 70;
                    armor = 7 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.35);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 2);
                    break;
                case 8:
                    name = "Blitzen";
                    default_Damage = 6;
                    default_Health = 30;
                    armor = 7 * (player.level * 0.43);
                    health = default_Health * (player.level * 0.41);
                    damage = default_Damage * player.level;
                    exp = default_Exp * (player.level * 1.9);
                    break;
                default:
                    Console.WriteLine("There is sadly no enemy to spawn D:");
                    break;
            }
        }
    }
}
