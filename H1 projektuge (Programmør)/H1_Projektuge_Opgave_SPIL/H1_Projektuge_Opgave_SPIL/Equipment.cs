using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Projektuge_Opgave_SPIL
{
    class Equipment
    {
        public string name;
        public string description;
        public double health_Buff;
        public double armor_Buff;
        public int price;

        public Equipment(string name, string description, double health_Buff, double armor_Buff, int price)
        {
            this.name = name;
            this.description = description;
            this.health_Buff = health_Buff;
            this.armor_Buff = armor_Buff;
            this.price = price;
        }
    }
}
