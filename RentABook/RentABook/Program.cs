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
            lib.RegistredBooks();

            //===================================================== Her 

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
                    if (UsersChoice == "1")
                    {
                        Console.WriteLine("\n\nPlease long in with valid credentials, or create a new user.\nLogin in->");
                        Console.Write("Username: ");
                        string UserUsername = Console.ReadLine();
                        Console.Write("Password: ");
                        string UserPassword = Console.ReadLine();

                        bool testing = true;
                        foreach (var human in lib.humans)
                        {
                            if (UserUsername == human.Username && UserPassword == human.Password)
                            {
                                IsTrue = false;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Clear();
                                Console.WriteLine("You have now sucesfully loged in!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                IsTrue2 = false;
                                testing = false;
                            }
                            //else
                            //{
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine("Username and or password is incorrect!");
                            //    Console.ForegroundColor = ConsoleColor.Gray;
                            //    Console.WriteLine("\n\nPlease long in with valid credentials, or create a new user.\nLogin in->");
                            //    Console.Write("Username: ");
                            //    UserUsername = Console.ReadLine();
                            //    Console.Write("Password: ");
                            //    UserPassword = Console.ReadLine();
                            //}
                        }
                        //if (testing = true)
                        //{
                        //    Console.WriteLine("Username and or password was incorrect! Please try again!");
                        //}
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
                        Console.WriteLine(Name + "! Your account has now sucesfully been created! You can now log in, and rent a book legally\n\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        //Here i take the data from the users input and make it into a new user
                        lib.SignUp(Name, Age, Gender, Username, Password);
                    }
                    else if (UsersChoice == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                //================================================================================After login
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
                            NoBooksAvailable = "There is currently no books available";
                        }
                    }

                    if (AvailableBook >= lib.books.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(NoBooksAvailable);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hey there! Here are all the books available\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        int i = 0;
                        foreach (var book in lib.books)
                        {
                            if (book.bookRented == true)
                            {
                                Console.WriteLine("Nr." + i + "\nName: |" + book.name + "|   Publish date: " + book.publishedDate + "/" + book.publishedmonth + "/" + book.publishedYear + "\n");
                            }
                            i += 1;

                        }
                        //========================== available books shown ======================================

                        Console.WriteLine("Now! What book would you like to rent? Write the number of the book you'd like to rent!");
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


                    //lib.WelcomMessageMenu(); //skal ud og stå i en klasse. Opret et objekt og kald dem fra objektet.



                }
            }
        }
    }
}
