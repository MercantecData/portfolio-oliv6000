using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_projektuge_spil_opgave
{
    class Weapon
    {
        public string name;
        public string describtion;
        public int damage_Buff;
        public int price;

        public Weapon(string name, string describtion, int damage_Buff, int price)
        {
            this.name = name;
            this.describtion = describtion;
            this.damage_Buff = damage_Buff;
            this.price = price;
        }
    }
}
