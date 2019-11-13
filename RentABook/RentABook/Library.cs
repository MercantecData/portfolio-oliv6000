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
        public string[] test;

        public Library()
        {
            // Constructor - Det er en metode.
        }

        public void AddHumanToList(string name, int age, string gender, string username, string password)
        {
            humans.Add(new Human(name, age, gender, username, password));
        }
        public void SignUp(string Name, int Age, string Gender, string Username, string Password)
        {
            AddHumanToList(Name, Age, Gender, Username, Password);
        }
        public void RegistredBooks()
        {
            books.Add(new Book("Book about your mother", 12, 01, 2013, false));
            books.Add(new Book("Book about your father", 02, 12, 2020, true));
            books.Add(new Book("Book about you", 16, 2, 2020, false));
            books.Add(new Book("Book about your dog", 8, 12, 2025, true));
            books.Add(new Book("Book about JOEMAMA", 31, 05, 2016, true));
        }
        public void BooksInLibrary()
        {
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
                string BooksAvailable = i + ". Name: " + book.name + " Publish date: " + book.publishedDate + "/" + book.publishedmonth + "/" + book.publishedYear + "   Available: " + BookIsRented + "\n";
                i += 1;
            }
        }
        public void RentABookFunction()
        {
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
        }
        //=========================================================== Users
        private void Redirect() => BooksInLibrary();
        public void LogIn(string UserUsername, string UserPassword)
        {
            
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
