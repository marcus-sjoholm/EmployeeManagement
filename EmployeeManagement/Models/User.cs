using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class User
    {
        public string UserId { get; set; }
        
        public string FirstName { get; set; }

        // public string UserName { get; set; }
        // public string Password { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }


        //Skapa en ctor som låter skapa account med Username O password
        /*public User()
        {

        }*/


        public User(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }

        public void AccountCreated()
        {
            Console.WriteLine($" {0} created an account");
        }

    }
}

// Kanske man ska ha namn osv i account, och i user ha t.ex Username, password??
