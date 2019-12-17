using System;
using System.Threading;

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
            game_Menue();
        }

        public static void game(string player_Name)
        {
            // Creating contact with the other classes, so that i can call stuff i need to call, later on!
            Enemy enemy = new Enemy();
            Player player = new Player(player_Name);

            Console.WriteLine("Welcome " + player_Name + "!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("These are your current stats!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            player.set_Player_Stats();
            player.player_Startup_Stats();
            

            enemy.create_Enemy(player);
            combat(enemy, player);
        }
        public static void combat(Enemy enemy, Player player)
        {
            Console.Write("\n\nSantas evil raindeer ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" appeared!\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("It's stats are as follows-->");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nHealth: " + enemy.health + "\nDamage: " + enemy.damage + "\nArmor: " + enemy.armor + "\n===================================");

            
                bool isRunning = true;
            while (isRunning)
            {
                if (enemy.health > 0)
                {
                    Console.WriteLine("\nWhat will you do!\nattack or flee?");
                    string users_Choice = Console.ReadLine();
                    switch (users_Choice)
                    {
                        case "attack":
                            attack(enemy, player);

                            if (enemy.health > 0)
                            {
                                retaliation(enemy, player);
                            }
                            break;

                        case "flee":
                            Console.WriteLine("you cannot flee at this time!");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nPlease choose either 'attack' or 'flee'!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            users_Choice = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    isRunning = false;
                    Console.Write("\n\nYou have successfully killed ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(enemy.name);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Hurray!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You gained " + enemy.exp + " experience points!");
                    Console.ReadKey();
                }
            }
            


        }
        public static void game_Menue()
        {
            Console.WriteLine("What would you like to do?\nWrite the number of the activity you'd like to do!\n1. Play!\n2. Quit!\n");
            string users_Choice = Console.ReadLine();

            bool isRunning = true;
            while (isRunning)
            {
                switch (users_Choice)
                {
                    case "1":
                        isRunning = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nThe game will start shortly!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1200);
                        Console.WriteLine("\nBefore we get started, what should be the name of your character?");
                        string player_Name = Console.ReadLine();
                        Console.Clear();

                        game(player_Name);
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\nTerminating the game for you, just one moment!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1600);

                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose one of the following!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("1. Play!\n2. Quit!");
                        users_Choice = Console.ReadLine();
                        break;
                }
            }
        }
        public static void attack(Enemy enemy, Player player)
        {
            Random player_Random_Number = new Random();
            int player_Random_Damage = player_Random_Number.Next(player.damage * 100, player.damage * 150);
            double actual_Player_Random_Damage = player_Random_Damage / 100;
            Console.Write("\nYou attack ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" and deal: " + actual_Player_Random_Damage);

            enemy.health -= actual_Player_Random_Damage;
            Console.WriteLine(enemy.health);
        }
        public static void retaliation(Enemy enemy, Player player)
        {
            Random enemy_Random_Number = new Random();
            int enemy_Random_Damage = enemy_Random_Number.Next(enemy.damage * 100, enemy.damage * 150);
            double actual_Enemy_Random_Damage = enemy_Random_Damage / 100;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n" + enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(" retaliates, and hits you for: " + actual_Enemy_Random_Damage);

            player.health -= actual_Enemy_Random_Damage;

            Console.WriteLine("You not have " + player.health + " health");
        }
    }
}
