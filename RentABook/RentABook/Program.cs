using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RentABook
{
    class Program
    {
        public static string CurrentUser;
        static void Main(string[] args)
        {
            //lib.WelcomMessageMenu(); //skal ud og stå i en klasse. Opret et objekt og kald dem fra objektet.

            Library lib = new Library();
            lib.AddHumanToList("Oliver", 2, "male", "oliv", "hey");
            lib.RegistredBooks();

            //===================================================== Her starter koden

            bool IsTrue = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (IsTrue)
            {

                Console.WriteLine("Please pick on of the following------>");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Log in\n2. Sign up\n");

                bool IsTrue2 = true;
                while (IsTrue2)
                {
                    string UsersChoice = Console.ReadLine();
                    Console.Clear();
                    if (UsersChoice == "1")
                    {
                        bool testing = true;

                        while (testing == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Please long in with valid credentials\nLogin-->\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Thread.Sleep(200);
                            Console.Write("Username: ");
                            string UserUsername = Console.ReadLine();
                            Console.Write("Password: ");
                            string UserPassword = Console.ReadLine();

                            int AntalForsøg = 0;
                            foreach (var human in lib.humans)
                            {

                                AntalForsøg += 1;
                                if (UserUsername == human.Username && UserPassword == human.Password)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                    Console.WriteLine("You have now sucesfully loged in!\nPress any key to continue!");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.ReadKey();

                                    CurrentUser = human.name;

                                    IsTrue = false;
                                    IsTrue2 = false;
                                    testing = false;
                                }
                                else if (AntalForsøg >= lib.humans.Count)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nUsername and/or password is incorrect!\n");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }
                        }
                    }
                    else if (UsersChoice == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Before we get started, please tell me the following--->\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(200);
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
                        Console.WriteLine(Name + "! Your account has now sucesfully been created! You can now log in, and rent a book legally\n\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        //Here i take the data from the users input and create a new user with it
                        lib.SignUp(Name, Age, Gender, Username, Password);
                        Console.WriteLine("What would you like to do next?\n1. Log in\n2. Sign up\n");
                    }
                    else if (UsersChoice == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                //================================================================================After login
                Console.Clear();
                //=========================== Showing available books in library =====================<<>>
                bool IsTrue1 = true;
                string NoBooksAvailable = "";

                while (IsTrue1)
                {
                    int AvailableBook = 0;
                    foreach (var Unavailable in lib.books)
                    {
                        if (Unavailable.bookRented == false)
                        {
                            AvailableBook += 1;
                        }

                        if (AvailableBook >= lib.books.Count)
                        {
                            NoBooksAvailable = "There is currently no books available! Loggin you out!";
                        }
                    }

                    if (AvailableBook >= lib.books.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(NoBooksAvailable);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hey there " +CurrentUser+"! Here are all the books available at the moment\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        int i = 0;
                        foreach (var book in lib.books)
                        {
                            if (book.bookRented == true)
                            {
                                Console.WriteLine("Number: " + i + "\nName: " + book.name + " | Publish date: " + book.publishedDate + "/" + book.publishedmonth + "/" + book.publishedYear + "\n");
                            }
                            i += 1;

                        }
                        //========================== available books shown ======================================
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("What book would you like to rent? Write the number of the book you'd like to rent!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        int UserBookChoice = int.Parse(Console.ReadLine());
                        int ii = 1;
                        foreach (var book in lib.books)
                        {
                            if (UserBookChoice == ii)
                            {
                                Console.WriteLine("\nAre you sure you want to rent |" + lib.books[ii].name + "|  type y or n");
                                string UserYesOrNoRent = Console.ReadLine();
                                bool IsTrue3 = true;

                                while (IsTrue3)
                                {
                                    if (UserYesOrNoRent == "y")
                                    {
                                        IsTrue3 = false;
                                        Console.WriteLine("\nOkay fantastic! |" + lib.books[ii].name + "| is now rented to you!");
                                        lib.RentBook(ii);

                                        Console.WriteLine("Press a key to continue!");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else if (UserYesOrNoRent == "n")
                                    {
                                        IsTrue3 = false;
                                        Console.WriteLine("Okay!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please type y or n!");
                                        UserYesOrNoRent = Console.ReadLine();
                                    }
                                }
                            }
                            ii += 1;
                        }
                    }
                }
            }
        }
    }
}
