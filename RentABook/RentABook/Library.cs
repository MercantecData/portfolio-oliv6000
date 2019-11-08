using System;
using System.Collections.Generic;
using System.Text;

namespace RentABook
{
    class Library
    {
        public List<Human> humans = new List<Human>();
        public List<Book> books = new List<Book>();
        public string CurrentUser;
        public string BookIsRented;
        public string UserBookChoice;
        public string UsersDecision;

        public Library()
        {
            // Constructor - Det er en metode.
        }

        public void AddHumanToList(string name, int age, string gender, string username, string password)
        {
            humans.Add(new Human(name, age, gender, username, password));
        }
        public void SignUp()
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
            //LibraryAddHuman(Username, Password, Name, Age, Gender);
            AddHumanToList(Name, Age, Gender, Username, Password);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your account has now sucesfully been created, now please log in, if you want to rent a book legally.\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            WelcomMessageMenu();
        }
        public void WelcomMessageMenu()
        {
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
                    LogIn();
                }
                else if (UsersChoice == "2")
                {
                    IsTrue = false;
                    SignUp();
                }
                else if (UsersChoice == "")
                {

                }

            }
        }
        public void BooksInLibrary()
        {
            //===========================================================Book nr 1
            books.Add(new Book("Book about your mother", 12, 01, 2013, false));
            books.Add(new Book("Book about your father", 02, 12, 2020, true));
            books.Add(new Book("Book about you", 16, 2, 2020, false));
            books.Add(new Book("Book about your dog", 8, 12, 2025, true));
            books.Add(new Book("Book about JOEMAMA", 31, 05, 2016, true));


            //Console.WriteLine($"" + Book1.publishedDate + "/" + Book1.publishedmonth + "/" + Book1.publishedYear);

            //Console.WriteLine($"" + Book2.publishedDate + "/" + Book2.publishedmonth + "/" + Book2.publishedYear);

            //Console.WriteLine($"" + Book3.publishedDate + "/" + Book3.publishedmonth + "/" + Book3.publishedYear
            int i = 1;
            foreach (var book in books)
            {
                if (book.bookRented == true)
                {
                    BookIsRented = "Yes!";
                }
                else if (book.bookRented == false)
                {
                    BookIsRented = "no";
                }
                Console.WriteLine(i + ". Name: " + book.name + " Publish date: " + book.publishedDate + "/" + book.publishedmonth + "/" + book.publishedYear + "   Available: " + BookIsRented + "\n");
                i += 1;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What book would you like to rent?");
            Console.ForegroundColor = ConsoleColor.Gray;
            UserBookChoice = Console.ReadLine();

            foreach (var BookRent in books)
            {
                if (BookRent.bookRented == true)
                {
                    BookIsRented = "Yes!";
                }
                else if (BookRent.bookRented == false)
                {
                    BookIsRented = "no";
                }

                if (UserBookChoice == BookRent.name)
                {
                    Console.WriteLine("\nAre you sure, you want to rent the book: " + BookRent.name + "\ny/n");
                    UsersDecision = Console.ReadLine();
                    Console.WriteLine("");
                }
                if (UsersDecision == "y")
                {
                    BookRent.bookRented = false;
                    Console.WriteLine(CurrentUser + " You have now rented: " + BookRent.name);
                }
                else if (UsersDecision == "n")
                {
                    Console.WriteLine("Okay, Showing you available books again!");
                    Redirect();
                }
            }
            Console.WriteLine();
        }
        //=========================================================== Users
        private void Redirect() => BooksInLibrary();
        public void LogIn()
        {
            bool IsTrue = true;
            while (IsTrue)
            {
                Console.WriteLine("\n\nPlease long in with valid credentials, or create a new user.\nLogin in->");
                Console.Write("Username: ");
                string UserUsername = Console.ReadLine();
                Console.Write("Password: ");
                string UserPassword = Console.ReadLine();
                foreach (var human in humans)
                {
                    if (UserUsername == human.Username && UserPassword == human.Password)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\nYou have now sucesfully loged in!\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        IsTrue = false;
                        CurrentUser = human.name;

                    }
                }
            }
        }
        //========================================================== End of users
        public void RentABook()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome back " + CurrentUser + "!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("We have the following books available\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            BooksInLibrary();
        }

    }
}
