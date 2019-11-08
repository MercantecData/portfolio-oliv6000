using System;
using System.Collections.Generic;
using System.Text;

namespace RentABook
{
    class Human
    {
        public string name;
        public int age;
        public string gender;
        public bool rentedABook;
        private string username;
        private string password;

        public Human(string name, int age, string gender, string username, string password)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            Username = username;
            Password = password;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
