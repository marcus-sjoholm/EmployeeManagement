namespace EmployeeManagement.Collection
{
    using Interfaces;
    using Models;
    using System;

    internal static class Backend
    {
        public static void AdminMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("ADMIN MENU:");
            Console.WriteLine("1. Add department");
            Console.WriteLine("2. Add employee");
            Console.WriteLine("3. Move employee to new department");
            Console.WriteLine("4. Search for employee");
            Console.WriteLine("5. Remove employee");
            Console.WriteLine("6. Search statistics from one department");
            Console.WriteLine("7. List all departments");
            Console.WriteLine("10. Log out");
            Console.WriteLine("11. Exit program");
        }

        public static void AdminView()
        {
            AdminMenuOptions();

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add Department, enter name of new department:");
                        new Company().AddDepartment(Console.ReadLine());
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Add employee, list of avaialable departments:");
                        new Company().ViewDepartment();
                        Console.WriteLine("Enter which department to assign new employee to");
                        ((IEmployee)new Employee()).EmployeeDepartmentID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"New employee will be assigned to {((IEmployee)new Employee()).EmployeeDepartmentID}, enter employee details:");
                        Console.WriteLine("Enter employees full name:");
                        ((IEmployee)new Employee()).Name = Console.ReadLine();
                        Console.WriteLine("Enter employees years of experience:");
                        ((IEmployee)new Employee()).Experience = Convert.ToInt32(Console.ReadLine());
                        while (((IEmployee)new Employee()).Role != "Manager" && ((IEmployee)new Employee()).Role != "Employee" && ((IEmployee)new Employee()).Role != "Consultant")
                        {
                            Console.WriteLine("Enter employee role: (Manager, Employee or Consultant)");
                            ((IEmployee)new Employee()).Role = Console.ReadLine();
                        }
                        Console.WriteLine("Enter employees salary: ");
                        ((IEmployee)new Employee()).Salary = Convert.ToInt32(Console.ReadLine());
                        new Company().AddEmployee(new Employee(), out _);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Move employee to another department:");
                        new Company().EditEmployeeRole(Convert.ToInt32(Console.ReadLine()));

                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Do you want to search usign (ID) or (Name)? ");
                        string searchParameter = Console.ReadLine();
                        if (searchParameter == "ID" || searchParameter == "id" || searchParameter == "Id")
                        {
                            Console.Write("\nEnter the employee ID to search for: ");
                            new Company().ViewEmployee(Convert.ToInt32(Console.ReadLine()));
                        }
                        else
                        {
                            Console.Write("\nEnter the employee full name to search for: ");
                            new Company().ViewEmployee(Console.ReadLine());
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Remove employee from system. Enter employee ID:");
                        new Company().DeleteEmployee(Convert.ToInt32(Console.ReadLine()));

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("List of companys departments:");
                        new Company().ViewDepartment();
                        Console.WriteLine("Enter ID of the company you want to display statistics from:");
                        new Company().ViewStatistics(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Display all departments:");
                        new Company().ViewDepartment();
                        break;

                    case 10:
                        Console.Clear();
                        LogIn();
                        break;

                    case 11:
                        Console.Clear();
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }

        public static void EmployeeMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("EMPLOYEE MENU:");
            Console.WriteLine("1. Search for employee");
            Console.WriteLine("2. Search statistics from one department");
            Console.WriteLine("3. List all departments");
            Console.WriteLine("10. Log out");
            Console.WriteLine("11. Exit program");
        }

        public static void EmployeeView()
        {
            EmployeeMenuOptions();

            _ = new Employee();

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Do you want to search usign (ID) or (Name)? ");
                        string searchParameter = Console.ReadLine();
                        if (searchParameter == "ID" || searchParameter == "id" || searchParameter == "Id")
                        {
                            Console.Write("\nEnter the employee ID to search for: ");
                            new Company().ViewEmployee(Convert.ToInt32(Console.ReadLine()));
                        }
                        else
                        {
                            Console.Write("\nEnter the employee full name to search for: ");
                            new Company().ViewEmployee(Console.ReadLine());
                        }
                        break;

                    case 2:
                        Console.WriteLine("List of companys departments:");
                        new Company().ViewDepartment();
                        Console.WriteLine("Enter ID of the company you want to display statistics from:");
                        new Company().ViewStatistics(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("Display all departments:");
                        new Company().ViewDepartment();
                        break;

                    case 10:
                        LogIn();
                        break;

                    case 11:
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }

        public static void LogIn()
        {
            Console.WriteLine("Welcome to login page!");
            Console.WriteLine("Enter user name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            var password = Console.ReadLine();

            if (name == "admin1" && password == "admin1234")
            {
                AdminView();
            }
            else
            {
                EmployeeView();
            }
        }
    }
}