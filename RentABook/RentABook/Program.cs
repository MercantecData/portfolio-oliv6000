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
            lib.WelcomMessageMenu(); //skal ud og stå i en klasse. Opret et objekt og kald dem fra objektet.
        }
    }
}
