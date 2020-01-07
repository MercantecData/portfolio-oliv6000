using System;
using System.Collections.Generic;
using System.Threading;

namespace H1_Projektuge_Opgave_SPIL
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
