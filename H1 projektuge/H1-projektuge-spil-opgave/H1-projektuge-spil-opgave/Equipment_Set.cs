using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_projektuge_spil_opgave
{
    class Equipment_Set
    {
        public string name;
        public string description;
        public double health_Buff;
        public double armor_Buff;
        public int price;

        public Equipment_Set(string name, string description, double health_Buff, double armor_Buff, int price)
        {
            this.name = name;
            this.description = description;
            this.health_Buff = health_Buff;
            this.armor_Buff = armor_Buff;
            this.price = price;
        }
    }
}
