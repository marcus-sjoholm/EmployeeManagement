using System;

namespace EmployeeManagement.Collection
{
    internal class Backend : Employee
    {
        public static void CreateEmployeeAccount()
        {
        }

        public static void LogIn()
        {
            Console.WriteLine("Welcome to login page!");
            Console.WriteLine("Enter user name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter password:");
            var password = Console.ReadLine();

            if (name == "admin1" && password == "admin1234")
            {
                AdminAccess();
            }
            else
            {
                EmployeeAccess();
            }
        }
    }
}