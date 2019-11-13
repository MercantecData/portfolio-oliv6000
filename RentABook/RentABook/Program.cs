using System;
using System.Collections.Generic;
using System.Text;

namespace RentABook
{
    class Program
    {
        static void Main(string[] args)
        {

            Library lib = new Library();
            lib.AddHumanToList("Oliver", 2, "male", "oliv", "hey");

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
                    Console.WriteLine("\n\nPlease long in with valid credentials, or create a new user.\nLogin in->");
                    Console.Write("Username: ");
                    string UserUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    string UserPassword = Console.ReadLine();

                    bool IsTrue2 = true;
                    while (IsTrue2)
                    {
                        foreach (var human in lib.humans)
                        {
                            if (UserUsername == human.Username && UserPassword == human.Password)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n\nYou have now sucesfully loged in!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                IsTrue2 = false;
                            }
                        }
                    }
                }
                else if (UsersChoice == "2")
                {
                    Console.WriteLine("\n\nPlease create a user, if you want to rent a book legally!");
                    Console.WriteLine("Before we get started, please tell me the following--->\n");
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();

                    Console.Write("Age: ");
                    int Age = int.Parse(Console.ReadLine());

                    Console.Write("Gender: ");
                    string Gender = Console.ReadLine();

                    Console.Write("Create username: ");
                    string Username = Console.ReadLine();
                    Console.Write("Create password: ");
                    string Password = Console.ReadLine();

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine (Name +"! Your account has now sucesfully been created! You can now log in, and rent a book legally\n\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    //Here i take the data from the users input and make it into a new user
                    lib.SignUp(Name, Age, Gender, Username, Password);
                }
                else if (UsersChoice == "")
                {

                }
            }
            //================================================================================After login
            lib.RegistredBooks();
            Console.WriteLine("Hey there! Here are all the books available\n");
            int i = 1;
            foreach (var book in lib.books)
            {
                if (book.bookRented == true)
                {
                    Console.WriteLine(i + ". Name: " + book.name + " Publish date: " + book.publishedDate + "/" + book.publishedmonth + "/" + book.publishedYear + "\n");
                    i += 1;
                }
            }

            






            //lib.WelcomMessageMenu(); //skal ud og stå i en klasse. Opret et objekt og kald dem fra objektet.




        }
    }
}
