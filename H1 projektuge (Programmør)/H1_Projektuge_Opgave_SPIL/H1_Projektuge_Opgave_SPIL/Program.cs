using System;
using System.Collections.Generic;
using System.Threading;

namespace H1_Projektuge_Opgave_SPIL
{
    class Program
    {
        static List<Equipment> equipment = new List<Equipment>();
        public static int fucktard = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n███████╗ █████╗ ███╗   ██╗████████╗ █████╗      ██████╗  ██████╗ ███╗   ██╗███████╗    ██████╗  ██████╗ ██╗   ██╗ ██████╗ ███████╗");
            Console.WriteLine("██╔════╝██╔══██╗████╗  ██║╚══██╔══╝██╔══██╗    ██╔════╝ ██╔═══██╗████╗  ██║██╔════╝    ██╔══██╗██╔═══██╗██║   ██║██╔════╝ ██╔════╝");
            Console.WriteLine("███████╗███████║██╔██╗ ██║   ██║   ███████║    ██║  ███╗██║   ██║██╔██╗ ██║█████╗      ██████╔╝██║   ██║██║   ██║██║  ███╗█████╗  ");
            Console.WriteLine("╚════██║██╔══██║██║╚██╗██║   ██║   ██╔══██║    ██║   ██║██║   ██║██║╚██╗██║██╔══╝      ██╔══██╗██║   ██║██║   ██║██║   ██║██╔══╝  ");
            Console.WriteLine("███████║██║  ██║██║ ╚████║   ██║   ██║  ██║    ╚██████╔╝╚██████╔╝██║ ╚████║███████╗    ██║  ██║╚██████╔╝╚██████╔╝╚██████╔╝███████╗");
            Console.WriteLine("╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚══════╝    ╚═╝  ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝ ╚══════╝\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            game_Menue();
        }

        public static void creating_Equipment()
        {
            //============================ Removing nr 0 in array =================================
            equipment.Add(new Equipment("0", "0", 0, 0, 0,0));
            //=====================================================================================

            //============================ Chestplate =============================================
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn tough", 30.5, 25, 20, 2200));
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn weak", 10.5, 5, 1, 600));
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn massive", 50.5, 15, 0, 2500));
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn decent", 25.5, 20, 15, 2000));
            //=====================================================================================

            //============================ Leggins ================================================
            equipment.Add(new Equipment("Leggins", "It's fuuckinn tough", 30.5, 25, 20, 2200));
            equipment.Add(new Equipment("Leggins", "It's fuuckinn weak", 10.5, 5, 1, 600));
            equipment.Add(new Equipment("Leggins", "It's fuuckinn massive", 50.5, 15, 0, 2500));
            equipment.Add(new Equipment("Leggins", "It's fuuckinn decent", 25.5, 20, 15, 2000));
            //=====================================================================================

            //============================ Helmet =================================================
            equipment.Add(new Equipment("Helmet", "It's fuuckinn tough", 30.5, 25, 20, 2200));
            equipment.Add(new Equipment("Helmet", "It's fuuckinn weak", 10.5, 5, 1, 600));
            equipment.Add(new Equipment("Helmet", "It's fuuckinn massive", 50.5, 15, 0, 2500));
            equipment.Add(new Equipment("Helmet", "It's fuuckinn decent", 25.5, 20, 15, 2000));
            //=====================================================================================

            //============================ Boots ==================================================
            equipment.Add(new Equipment("Boots", "It's fuuckinn tough", 30.5, 25, 20, 2200));
            equipment.Add(new Equipment("Boots", "It's fuuckinn weak", 10.5, 5, 1, 600));
            equipment.Add(new Equipment("Boots", "It's fuuckinn massive", 50.5, 15, 0, 2500));
            equipment.Add(new Equipment("Boots", "It's fuuckinn decent", 25.5, 20, 15, 2000));
            //=====================================================================================

        }
        public static void chest_Encounter(Player player)
        {
            creating_Equipment();

            Console.WriteLine("\n==================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press a key to open the chest!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("awaiting keypress...");
            Console.ReadKey();

            Random random = new Random();
            int random_Equipment = random.Next(1, 17);
            int random_Weapon = random.Next(1, 17);

            int equipment_Or_Weapon = random.Next(1, 3);
            if (equipment_Or_Weapon == 1)
            {
                if (equipment[random_Equipment].name == "Chestplate" || equipment[random_Equipment].name == "Helmet")
                {
                    Console.WriteLine("\n1You found a " + equipment[random_Equipment].name);
                }
                else
                {
                    Console.WriteLine("\n1You found " + equipment[random_Equipment].name);
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWhat would you like to with it?");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Write the number of the action you'd like to do!");
                
                bool isRunning = true;

                while (isRunning)
                {
                    Console.WriteLine("1. inspect\n2. equip\n3. Throw away");
                    string user_Choice = Console.ReadLine();

                    if (user_Choice == "1")
                    {
                        isRunning = false;
                        Console.WriteLine("\nThe item's stats are as follows---->");
                        inspect(equipment[random_Equipment], player);
                    }
                    else if (user_Choice == "2")
                    {
                        isRunning = false;
                        equipment_Equip(player, equipment[random_Equipment]);

                    }
                    else if (user_Choice == "3")
                    {
                        isRunning = false;
                        Console.WriteLine("\nYou throw the equipment away!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nplease choose one of the following!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

            }
            else if (equipment_Or_Weapon == 2)
            {
                //Console.WriteLine("\n2You found--->\nName: " + Weapon[random_Weapon].name);
                if (equipment[random_Equipment].name == "Chestplate" || equipment[random_Equipment].name == "Helmet")
                {
                    Console.WriteLine("\n2You found a " + equipment[random_Equipment].name);
                }
                else
                {
                    Console.WriteLine("\n2You found " + equipment[random_Equipment].name);
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nWhat would you like to with the: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }

        }
        public static void inspect(Equipment equipment, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("describtion: " + equipment.description + "\nHealth buff:" + equipment.health_Buff + "\nArmor buff: " + equipment.armor_Buff + "\nevasiveness buff: " + equipment.evasiveness_Buff);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat do you want to do now?\n1. equip\n2. throw away");
            string user_Choice = Console.ReadLine();

            if (user_Choice == "1" || user_Choice == "equip")
            {
                equipment_Equip(player, equipment);
            }
            else if (user_Choice == "2" || user_Choice == "throw away")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThrowing away the " + equipment.name + "!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write("Now! ");
        }
        public static void game_Menue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What would you like to do?");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Write the number of the activity you'd like to do!\n1. Play!\n2. Quit!\n");
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
        public static void game(string player_Name)
        {
            // Creating contact with the other classes, so that i can call stuff i need to call, later on!
            Enemy enemy = new Enemy();
            Player player = new Player(player_Name);

            Console.WriteLine("Welcome " + player_Name + "!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("These are your current stats!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            player.startup_Stats();
            navigation(enemy, player);
        }
        public static void equipment_Equip(Player player, Equipment equipment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipping the ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(equipment.name);
            Console.ReadKey();
            player.update_Stats(equipment);
        }
        public static void navigation(Enemy enemy, Player player)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Where would you like to go?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("north, east, south or west");

            string player_Direction = Console.ReadLine();

            switch (player_Direction)
            {
                case "north":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You start walking towards north!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    encounter(enemy, player);
                    navigation(enemy, player);
                    break;

                case "east":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You start walking towards east!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    encounter(enemy, player);
                    navigation(enemy, player);
                    break;

                case "south":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You start walking towards south!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    encounter(enemy, player);
                    navigation(enemy, player);
                    break;

                case "west":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You start walking towards west!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    encounter(enemy, player);
                    navigation(enemy, player);
                    break;

                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You walk nowhere?!?!?!?!?!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }

        }
        public static void encounter(Enemy enemy, Player player)
        {
            Random random = new Random();
            int random_Encounter = random.Next(1, 5);

            switch (random_Encounter)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You encounter a merchant!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    //combat(enemy, player);
                    chest_Encounter(player);
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You find a chest!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    chest_Encounter(player);
                    //combat(enemy, player);
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You encounter an enemy!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    //combat(enemy, player);
                    chest_Encounter(player);
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You encounter an enemy!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    //combat(enemy, player);
                    chest_Encounter(player);
                    break;

                default:
                    Console.WriteLine("An error occured");
                    break;
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
            Thread.Sleep(800);
        }
        public static void combat(Enemy enemy, Player player)
        {
            enemy.create_Enemy(player);
            Console.WriteLine("\n\n==========================");
            Console.Write("Santas evil raindeer ");
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
                            Random random = new Random();
                            int oneToFour = random.Next(1, 5);

                            switch (oneToFour)
                            {
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You successfully flee!");
                                    Console.ForegroundColor = ConsoleColor.Red;


                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nFlee failed!");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(" Therefore ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(enemy.name);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine(" gets a free turn");

                                    retaliation(enemy, player);
                                    break;
                            }

                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nPlease choose either 'attack' or 'flee'!");
                            Console.ForegroundColor = ConsoleColor.Gray;
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

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nYou gain " + enemy.exp + " experience points!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    player_Experience_and_level(enemy, player);
                    Console.WriteLine("You now have " + player.exp + " experience points!");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nPress any key to continue!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                    navigation(enemy, player);
                }
            }



        }
        public static void retaliation(Enemy enemy, Player player)
        {
            // Creating a randomizer with double digit numbers
            Random enemy_Random_Number = new Random();
            int enemy_Random_Damage = enemy_Random_Number.Next(enemy.damage * 150, enemy.damage * 200);
            double actual_Enemy_Random_Damage = enemy_Random_Damage / 100;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n" + enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(" retaliates, and hits you for: " + actual_Enemy_Random_Damage);

            player.health -= actual_Enemy_Random_Damage;

            Console.WriteLine("You now have " + player.health + " health\n");
        }
        public static void player_Experience_and_level(Enemy enemy, Player player)
        {
            player.exp += enemy.exp;
            double[] exp = new double[10] {125, 250, 500, 1000, 2000, 4000, 8000, 16000, 32000, 64000};
            int i = 1;
            bool isRunning = false;

            foreach (int exp_cap in exp)
            {
                i += 1;
                    if (player.exp >= exp_cap)
                    {
                        player.level = i;
                        isRunning = true;
                    }
            }

            while (isRunning)
                {
                    
                    if (fucktard != player.level)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        fucktard = player.level;
                        Console.WriteLine("\nYOU REACHED LEVEL " + player.level + "!!!! CONGRATZ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        isRunning = false;
                    }
                }
        }
    }
}
