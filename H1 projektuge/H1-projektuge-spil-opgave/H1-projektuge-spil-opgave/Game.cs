using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace H1_projektuge_spil_opgave
{
    class Game
    {
        public static int i = 1;
        public static int y = 0;



        public void startup()
        {
            Game game = new Game();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ███████╗ █████╗ ███╗   ██╗████████╗ █████╗      ██████╗  ██████╗ ███╗   ██╗███████╗    ██████╗  ██████╗ ██╗   ██╗ ██████╗ ███████╗");
            Console.WriteLine(" ██╔════╝██╔══██╗████╗  ██║╚══██╔══╝██╔══██╗    ██╔════╝ ██╔═══██╗████╗  ██║██╔════╝    ██╔══██╗██╔═══██╗██║   ██║██╔════╝ ██╔════╝");
            Console.WriteLine(" ███████╗███████║██╔██╗ ██║   ██║   ███████║    ██║  ███╗██║   ██║██╔██╗ ██║█████╗      ██████╔╝██║   ██║██║   ██║██║  ███╗█████╗  ");
            Console.WriteLine(" ╚════██║██╔══██║██║╚██╗██║   ██║   ██╔══██║    ██║   ██║██║   ██║██║╚██╗██║██╔══╝      ██╔══██╗██║   ██║██║   ██║██║   ██║██╔══╝  ");
            Console.WriteLine(" ███████║██║  ██║██║ ╚████║   ██║   ██║  ██║    ╚██████╔╝╚██████╔╝██║ ╚████║███████╗    ██║  ██║╚██████╔╝╚██████╔╝╚██████╔╝███████╗");
            Console.WriteLine(" ╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚══════╝    ╚═╝  ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝ ╚══════╝\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            game.menue();
        }
        public void game(string player_Name)
        {
            // Creating contact with the other classes, so that i can call stuff i need to call, later on!
            Enemy enemy = new Enemy();
            Player player = new Player(player_Name);
            List<Equipment_Set> equipment = new List<Equipment_Set>();
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
        public void menue()
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
        public void create_Equipments(List<Equipment_Set> equipment)
        {
            //============================ Creating equipment sets, which means entire sets of armor =============================================
            //removing the list val 0 ==============================
            equipment.Add(new Equipment_Set("0", "0", 0, 0, 0));
            //======================================================

            equipment.Add(new Equipment_Set("Decent set", "It's fuuckinn decent!", 35, 15, 3200));
            equipment.Add(new Equipment_Set("Weak set", "It's fuuckinn weak!", 5, 2, 500));
            equipment.Add(new Equipment_Set("Good set", "It's actually pretty good!", 30, 20, 3600));
            equipment.Add(new Equipment_Set("Budget set", "i mean, what do you expect of a budget set, it's DOGSH*T", 8, 5, 2000));
            equipment.Add(new Equipment_Set("OP set", "It's fuuckinn decent", 50, 30, 10000));
        }
        public void create_Weapons(List<Weapon> weapon)
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
        public void chest_Encounter(List<Weapon> weapon, List<Equipment_Set> equipment, Player player)
        {
            Console.WriteLine("\n==================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press a key to open the chest!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("awaiting keypress...");
            Console.ReadKey();
            Console.WriteLine("==============================");

            Random random = new Random();
            int random_Equipment = random.Next(1, 6);
            int random_Weapon = random.Next(1, 10);

            // Gør lige så OP sword bliver extra svær og finde, da der var lige stor sansynlighed før!
            if (weapon[random_Weapon].name == "OP sword")
            {
                random_Weapon = random.Next(1, 10);
            }
            // Og her gør jeg så op set bliver lidt svære og finde!
            if (equipment[random_Equipment].name == "OP set")
            {
                random_Equipment = random.Next(1, 6);
            }
            // her slutter det!

            int equipment_Or_Weapon = random.Next(1, 3);
            if (equipment_Or_Weapon == 1)
            {
                Console.WriteLine("\nYou found a " + equipment[random_Equipment].name + "!");


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
        public void merchant_Encounter(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe merchant fully restored your hp!");
            Console.ForegroundColor = ConsoleColor.Gray;
            player.merchant_Healing(player);

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
        }
        public void inspect_Equipment(Equipment_Set equipment, Player player)
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
        }
        public void inspect_Weapon(Weapon weapon, Player player)
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
        public void equip_Equipment(Player player, Equipment_Set equipment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipping the ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(equipment.name);

            player.update_Stats_With_Equipment(equipment, player);

            Thread.Sleep(1000);
        }
        public void equip_Weapon(Player player, Weapon weapon)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipping the ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(weapon.name);

            player.update_Stats_With_Weapon(weapon, player);
            Thread.Sleep(1200);
        }
        public void navigation(List<Weapon> weapon, List<Equipment_Set> equipment, Enemy enemy, Player player)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Where would you like to go? You can also type 'stats' to see your improvements");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("north, east, south or west. You can alost write 'SantaClause' to fight the boss(disclaimer: HE IS OPOP)");


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

                    case "SantaClause":
                        encounter_Santa(enemy, weapon, equipment, player);
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
        public void encounter_Santa(Enemy enemy, List<Weapon> weapon, List<Equipment_Set> equipment, Player player)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HO HO HO HO HOOOOOOOOOOOOO!\n");

            enemy.create_Santa(player);
            combat(weapon, equipment, enemy, player);
        }
        public void encounter(List<Weapon> weapon, List<Equipment_Set> equipment, Enemy enemy, Player player)
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

                    chest_Encounter(weapon, equipment, player);
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You encounter an enemy!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    enemy.create_Enemy(player);
                    combat(weapon, equipment, enemy, player);
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You encounter an enemy!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    enemy.create_Enemy(player);
                    combat(weapon, equipment, enemy, player);
                    break;

                default:
                    Console.WriteLine("An error occured");
                    break;
            }
        }
        public void attack(Enemy enemy, Player player)
        {
            Random player_Random_Number = new Random();
            int player_Random_Damage = player_Random_Number.Next(player.damage * 100, player.damage * 150);
            double actual_Player_Random_Damage = player_Random_Damage / 100;
            Console.Write("\nYou attack ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;


            double player_Damage = actual_Player_Random_Damage - (enemy.armor * 0.78);
            Console.Write(" and deal: " + actual_Player_Random_Damage);

            enemy.health -= player_Damage;
            Thread.Sleep(800);
        }
        public void combat(List<Weapon> weapon, List<Equipment_Set> equipment, Enemy enemy, Player player)
        {

            if (enemy.name == "Santa clause")
            {

            }
            else
            {
                Console.Write("\nSantas evil raindeer ");
            }
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
                    Console.ForegroundColor = ConsoleColor.Gray;
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
        public void retaliation(Enemy enemy, Player player)
        {
            // Creating a randomizer with double digit numbers
            Random enemy_Random_Number = new Random();
            int enemy_Random_Damage = enemy_Random_Number.Next(enemy.damage * 150, enemy.damage * 200);
            double actual_Enemy_Random_Damage = enemy_Random_Damage / 100;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n" + enemy.name);
            Console.ForegroundColor = ConsoleColor.Gray;

            double enemy_Damage = actual_Enemy_Random_Damage - (player.armor * 0.25);
            Console.WriteLine(" retaliates, and hits you for: " + enemy_Damage + "");
            player.health -= enemy_Damage;

            if (player.health <= 0)
            {
                Console.Clear();
                Console.Write("Damn dude, ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("you died! ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Better luck next time!");
                Console.WriteLine("=================================");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Do you want to play again? yes or no!");
                Console.ForegroundColor = ConsoleColor.Gray;
                string users_Choice = Console.ReadLine();

                switch (users_Choice)
                {
                    case "yes":
                        Console.Clear();
                        startup();
                        break;

                    case "no":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("You now have " + player.health + " health\n");
            }
        }
        public void player_Experience_and_level(Enemy enemy, Player player)
        {
            player.exp += enemy.exp;
            double[] exp = new double[10] { 500, 1000, 2000, 4000, 8000, 13000, 16000, 20000, 28000, 36000 };
            int x = 1;
            foreach (int exp_cap in exp)
            {
                x += 1;
                if (player.exp >= exp_cap)
                {
                    player.level = x;
                }
            }

            if (i != player.level)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                i = player.level;
                Console.WriteLine("\nYOU REACHED LEVEL " + player.level + "!!!! CONGRATZ\nYour hp was restored");
                player.level_Up(player);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
