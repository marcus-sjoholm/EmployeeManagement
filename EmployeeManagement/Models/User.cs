using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class User
    {
        public string UserId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public int Age { get; set; }

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
