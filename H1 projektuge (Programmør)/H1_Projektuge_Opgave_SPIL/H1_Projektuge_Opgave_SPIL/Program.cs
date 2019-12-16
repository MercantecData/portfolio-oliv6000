using System;

namespace H1_Projektuge_Opgave_SPIL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SANTA GONE ROUGE!\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("What would you like your character's name to be: ");
            string player_Name = Console.ReadLine();
            Player player = new Player(player_Name);

            creating_Enemys();
        }

        public static void creating_Enemys()
        {
            Enemy Dasher = new Enemy();
        }
    }
}
