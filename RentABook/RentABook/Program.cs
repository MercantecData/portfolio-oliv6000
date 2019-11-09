using System;
using System.Collections.Generic;

namespace RentABook
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.AddHumanToList("hey", 2, "male", "oliv", "hey");

            //===================================================== Her 

            bool IsTrue = true;

            while (IsTrue)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please pick on of the following------>");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Log in\n2. Sign up\n");

                string UsersChoice = Console.ReadLine();

                if (UsersChoice == "1")
                {
                    IsTrue = false;
                    lib.LogIn();
                }
                else if (UsersChoice == "2")
                {
                    IsTrue = false;
                    lib.SignUp();
                }
                else if (UsersChoice == "")
                {

                }
            }
            lib.WelcomMessageMenu(); //skal ud og stå i en klasse. Opret et objekt og kald dem fra objektet.




        }
    }
}
