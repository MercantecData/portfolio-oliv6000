using System;
using System.Collections.Generic;
using System.Threading;

namespace H1_Projektuge_Opgave_SPIL
{
    class Program
    {
        public static int i = 0;
        public static int y = 0;
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

        public static void create_Equipments(List<Equipment> equipment)
        {
            //============================ Chestplate =============================================
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn tough", 30.5, 25, 2200));
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn weak", 10.5, 5, 600));
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn massive", 50.5, 15, 2500));
            equipment.Add(new Equipment("Chestplate", "It's fuuckinn decent", 25.5, 20, 2000));
            //=====================================================================================

            //============================ Leggins ================================================
            equipment.Add(new Equipment("Leggins", "It's fuuckinn tough", 25, 30, 2200));
            equipment.Add(new Equipment("Leggins", "It's fuuckinn weak", 8, 5, 600));
            equipment.Add(new Equipment("Leggins", "It's fuuckinn massive", 45.5, 15, 2500));
            equipment.Add(new Equipment("Leggins", "It's fuuckinn decent", 22.5, 20, 2000));
            //=====================================================================================

            //============================ Helmet =================================================
            equipment.Add(new Equipment("Helmet", "It's fuuckinn tough", 20.5, 25, 2200));
            equipment.Add(new Equipment("Helmet", "It's fuuckinn weak", 7.5, 5, 600));
            equipment.Add(new Equipment("Helmet", "It's fuuckinn massive", 30.5, 20, 2500));
            equipment.Add(new Equipment("Helmet", "It's fuuckinn decent", 17.5, 15, 2000));
            //=====================================================================================

            //============================ Boots ==================================================
            equipment.Add(new Equipment("Boots", "It's fuuckinn tough", 10.5, 15, 2200));
            equipment.Add(new Equipment("Boots", "It's fuuckinn weak", 4, 3, 600));
            equipment.Add(new Equipment("Boots", "It's fuuckinn massive", 26.5, 10, 2500));
            equipment.Add(new Equipment("Boots", "It's fuuckinn decent", 12.5, 12, 2000));
            //=====================================================================================

        }
        public static void create_Weapons(List<Weapon> weapon)
        {
            // ============== removing List[0] ===========
            weapon.Add(new Weapon("0", "0", 0, 0));
            // ===========================================

            weapon.Add(new Weapon("Blood thrister", "It's fuuckinn loooooong", 12, 3200));
            weapon.Add(new Weapon("Fat sword", "this is some heavy duty damageeeeee", 20, 6200));
            weapon.Add(new Weapon("Thin sword", "this might brake at some point! basically as usefull as the twig", 3, 300));
            weapon.Add(new Weapon("Majestic sword", "pretty damn golden, but not that powerfulle", 14, 5400));
            weapon.Add(new Weapon("OP sword", "well you might just have won the game", 50, 100000));
            weapon.Add(new Weapon("Shitty sword", "i mean, it almost does not get worse than this", 4, 400));
            weapon.Add(new Weapon("Decent sword", "An average sword, not too rare.", 15, 4200));
            weapon.Add(new Weapon("Almost perfect sword", "Almost as good as excalibur", 30, 10000));
            weapon.Add(new Weapon("Twig", "It's just a freaking stick", 2, 100));
        }
        public static void chest_Encounter(List<Weapon> weapon, List<Equipment> equipment, Player player)
        {            
            Console.WriteLine("\n==================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press a key to open the chest!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("awaiting keypress...");
            Console.ReadKey();
            Console.WriteLine("==============================");

            Random random = new Random();
            int random_Equipment = random.Next(1, 16);
            int random_Weapon = random.Next(1, 10);

            // Gør lige så OP sword bliver extra svær og finde, da der var lige stor sansynlighed før!
            if (weapon[random_Weapon].name == "OP sword")
            {
                random_Weapon = random.Next(1, 10);
            }
            // her slutter det!

            int equipment_Or_Weapon = random.Next(1, 3);
            if (equipment_Or_Weapon == 1)
            {
                if (equipment[random_Equipment].name == "Chestplate" || equipment[random_Equipment].name == "Helmet")
                {
                    Console.WriteLine("\nYou found a " + equipment[random_Equipment].name + "!");
                }
                else
                {
                    Console.WriteLine("\nYou found " + equipment[random_Equipment].name + "!");
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWhat would you like to do with it?");
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
                        inspect_Equipment(equipment[random_Equipment], player);
                    }
                    else if (user_Choice == "2")
                    {
                        isRunning = false;
                        y = random_Equipment;
                        equip_Equipment(player, equipment[random_Equipment]);
                    }
                    else if (user_Choice == "3")
                    {
                        isRunning = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nYou throw the equipment away!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1200);
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


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(random_Weapon);
                Console.ForegroundColor = ConsoleColor.Gray;


                Console.WriteLine("\nYou found a " + weapon[random_Weapon].name + "!");
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWhat would you like to do with it?");
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
                        inspect_Weapon(weapon[random_Weapon], player);
                    }
                    else if (user_Choice == "2")
                    {
                        isRunning = false;
                        equip_Weapon(player, weapon[random_Weapon]);

                    }
                    else if (user_Choice == "3")
                    {
                        isRunning = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nYou throw the equipment away!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1200);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nplease choose one of the following!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }

        }
        public static void merchant_Encounter(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe merchant fully restored your hp!");
            Console.ForegroundColor = ConsoleColor.Gray;
            player.merchant_Healing(player);

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
        }
        public static void inspect_Equipment(Equipment equipment, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Describtion: " + equipment.description + "\nHealth buff:" + equipment.health_Buff + "\nArmor buff: " + equipment.armor_Buff);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat do you want to do now?\n1. Equip\n2. Throw away");
            string user_Choice = Console.ReadLine();

            if (user_Choice == "1" || user_Choice == "equip")
            {
                equip_Equipment(player, equipment);
            }
            else if (user_Choice == "2" || user_Choice == "throw away")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nThrowing away the ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(equipment.name + "!");
                Thread.Sleep(1200);
            }
            Console.Write("Now! ");
        }
        public static void inspect_Weapon(Weapon weapon, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Describtion: " + weapon.describtion + "\nDamage buff:" + weapon.damage_Buff + "\nPrice: " + weapon.price);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat do you want to do now?\n1. Equip\n2. Throw away");
            string user_Choice = Console.ReadLine();

            if (user_Choice == "1" || user_Choice == "equip")
            {
                equip_Weapon(player, weapon);
            }
            else if (user_Choice == "2" || user_Choice == "throw away")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nThrowing away the ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(weapon.name + "!");
                Thread.Sleep(1200);
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
            List<Equipment> equipment = new List<Equipment>();
            List<Weapon> weapon = new List<Weapon>();

            Console.WriteLine("Welcome " + player_Name + "!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("These are your starter stats!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            player.Initiating_Stats(player);
            player.setup_Stats(player);
            create_Equipments(equipment);
            create_Weapons(weapon);

            navigation(weapon, equipment, enemy, player);
        }
        public static void equip_Equipment(Player player, Equipment equipment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipping the ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(equipment.name);

            player.update_Stats_With_Equipment(equipment, player);

            Thread.Sleep(1000);
        }
        public static void equip_Weapon(Player player, Weapon weapon)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipping the ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(weapon.name);

            player.update_Stats_With_Weapon(weapon, player);

            Console.WriteLine("this is the player damage: " + player.damage + "\nThis is the weapon damage: " + weapon.damage_Buff);
            Console.ReadKey();
            Thread.Sleep(1000);
        }
        public static void navigation(List<Weapon> weapon, List<Equipment> equipment, Enemy enemy, Player player)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Where would you like to go? You can also type 'stats' to see your improvements");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("north, east, south or west");


            bool isRunning = true;

            while (isRunning)
            {
                string player_Direction = Console.ReadLine();
                switch (player_Direction)
                {
                    case "north":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You start walking towards north!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("==============================");

                        encounter(weapon, equipment, enemy, player);
                        navigation(weapon, equipment, enemy, player);
                        break;

                    case "east":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You start walking towards east!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("==============================");

                        encounter(weapon, equipment, enemy, player);
                        navigation(weapon, equipment, enemy, player);
                        break;

                    case "south":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You start walking towards south!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("==============================");

                        encounter(weapon, equipment, enemy, player);
                        navigation(weapon, equipment, enemy, player);
                        break;

                    case "west":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You start walking towards west!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("==============================");

                        encounter(weapon, equipment, enemy, player);
                        navigation(weapon, equipment, enemy, player);
                        break;

                    case "stats":
                        player.show_Stats(player);
                        navigation(weapon, equipment, enemy, player);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You want to go nowhere!?!?!?!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Gimme a damn location, where do you want to go?");
                        Console.WriteLine("north? west? south? east? You can also still write 'stats' to see your improvements!");
                        break;
                }
            }
        }
        public static void encounter(List<Weapon> weapon, List<Equipment> equipment, Enemy enemy, Player player)
        {
            Random random = new Random();
            int random_Encounter = random.Next(1, 5);

            switch (random_Encounter)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You encounter a merchant!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    merchant_Encounter(player);
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You find a chest!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    chest_Encounter(weapon, equipment ,player);
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You encounter an enemy!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    combat(weapon, equipment, enemy, player);
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You encounter an enemy!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    combat(weapon, equipment, enemy, player);
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
        public static void combat(List<Weapon> weapon, List<Equipment> equipment, Enemy enemy, Player player)
        {
            enemy.create_Enemy(player);
            Console.Write("\nSantas evil raindeer ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" appeared!\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("It's stats are as follows-->");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("======================");

            Console.WriteLine("\nHealth: " + enemy.health + "\nDamage: " + enemy.damage + "\nArmor: " + enemy.armor + "\n======================");


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
                                    Console.WriteLine("Press a key to continue!");
                                    Console.ReadKey();


                                    navigation(weapon, equipment, enemy, player);
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

                    navigation(weapon, equipment, enemy, player);
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

            player.health -= actual_Enemy_Random_Damage - (player.armor * 0.85);

            Console.WriteLine("You now have " + player.health + " health\n");
        }
        public static void player_Experience_and_level(Enemy enemy, Player player)
        {
            player.exp += enemy.exp;
            double[] exp = new double[10] {500, 1000, 2000, 4000, 8000, 13000, 16000, 20000, 28000, 36000};
            int i = 1;
            foreach (int exp_cap in exp)
            {
                i += 1;
                if (player.exp >= exp_cap)
                {
                    player.level = i;
                }
            }

                if (i != player.level)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Program.i = player.level;
                    Console.WriteLine("\nYOU REACHED LEVEL " + player.level + "!!!! CONGRATZ\nYour hp was restored");
                    player.at_Level_Up(player);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
        }
    }
}
