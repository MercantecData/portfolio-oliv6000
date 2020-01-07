using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_projektuge_spil_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(132, 30);
            Game game = new Game();
            game.startup();
        }
    }
}
