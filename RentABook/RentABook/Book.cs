using System;
using System.Collections.Generic;
using System.Text;

namespace RentABook
{
    class Book
    {
        public string name;
        public int publishedDate;
        public int publishedmonth;
        public int publishedYear;
        public bool bookRented;

        public Book(string name, int publishedDate, int publishedmonth, int publishedYear, bool bookRented)
        {
            this.name = name;
            this.publishedDate = publishedDate;
            this.publishedmonth = publishedmonth;
            this.publishedYear = publishedYear;
            this.bookRented = bookRented;
        }
    }
}
