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
        public int default_Health;
        public int health;
        public int armor;
        public int experience_Amount;

        public Enemy()
        {

        }


        public void creating_Enemy()
        {
            switch (name)
            {
                case "Dasher":
                    default_Damage = 3;
                    break;
                case "Dancer":
                    default_Damage = 23123;
                    break;
                case "Prancer":
                    default_Damage = 2;
                    break;
                case "Vixen":
                    default_Damage = 2;
                    break;
                case "Comet":
                    default_Damage = 2;
                    break;
                case "Cupid":
                    default_Damage = 2;
                    break;
                case "Donner":
                    default_Damage = 2;
                    break;
                case "Blitzen":
                    default_Damage = 2;
                    break;

                default:
                    break;
            }



        }

    }
}
