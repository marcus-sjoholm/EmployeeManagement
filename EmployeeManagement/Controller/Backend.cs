namespace EmployeeManagement.Collection
{
    using Interfaces;
    using Models;
    using System;

    internal static class Backend
    {
        public static void AdminMenuOptions()
        {
            Console.WriteLine();
            Console.WriteLine("ADMIN MENU:");
            Console.WriteLine("1. Add department");
            Console.WriteLine("2. Add employee");
            Console.WriteLine("3. Move employee to new department");
            Console.WriteLine("4. Search for employee");
            Console.WriteLine("5. Remove employee");
            Console.WriteLine("6. Search statistics from one department");
            Console.WriteLine("7. List all departments");
            Console.WriteLine("8. List all employees");
            Console.WriteLine("10. Log out");
            Console.WriteLine("11. Exit program");
        }

        public static void AdminView(Company company, IEmployee employee)
        {
            company = new Company();
            employee = new Employee();

            AdminMenuOptions();

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Add Department, enter name of new department:");
                        var DepartmentName = Console.ReadLine();
                        company.AddDepartment(DepartmentName);

                        AdminMenuOptions();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Add employee, list of avaialable departments:");
                        company.ViewDepartment();
                        Console.WriteLine("Enter which department to assign new employee to");
                        employee.EmployeeDepartmentID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"New employee will be assigned to {employee.EmployeeDepartmentID}, enter employee details:");
                        Console.WriteLine("Enter employees full name:");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Enter employees years of experience:");
                        employee.Experience = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter role:");
                        employee.Role = Console.ReadLine();
                        while (employee.Role != "Manager" && employee.Role != "Employee" && employee.Role != "Consultant")
                        {
                            Console.WriteLine("Enter employee role: (Manager, Employee or Consultant)");
                            employee.Role = Console.ReadLine();
                        }
                        Console.WriteLine("Enter employees salary: ");
                        employee.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee password: ");
                        employee.Password = Console.ReadLine();
                        company.AddEmployee(employee, out _);
                        AdminMenuOptions();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Move employee to another department:");
                        company.EditEmployeeRole(Convert.ToInt32(Console.ReadLine()));
                        AdminMenuOptions();
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Do you want to search usign (ID) or (Name)? ");
                        string searchParameter = Console.ReadLine();
                        if (searchParameter == "ID" || searchParameter == "id" || searchParameter == "Id")
                        {
                            Console.Write("\nEnter the employee ID to search for: ");
                            company.ViewEmployee(Convert.ToInt32(Console.ReadLine()));
                            AdminMenuOptions();
                        }
                        else
                        {
                            Console.Write("\nEnter the employee full name to search for: ");
                            company.ViewEmployee(Console.ReadLine());
                            AdminMenuOptions();
                        }
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Remove employee from system. Enter employee ID:");
                        company.DeleteEmployee(Convert.ToInt32(Console.ReadLine()));
                        AdminMenuOptions();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("List of companys departments:");
                        company.ViewDepartment();
                        Console.WriteLine("Enter ID of the company you want to display statistics from:");
                        company.ViewStatistics(Convert.ToInt32(Console.ReadLine()));
                        AdminMenuOptions();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Display all departments:");
                        company.ViewDepartment();
                        AdminMenuOptions();
                        break;

                    case "8":
                        Console.Clear();
                        company.DisplayEmployees();
                        AdminMenuOptions();
                        break;

                    case "10":
                        Console.Clear();
                        LogIn(company, employee);
                        break;

                    case "11":
                        Console.Clear();
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
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

        public static void EmployeeView(Company company, IEmployee employee)
        {
            EmployeeMenuOptions();

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Do you want to search using (ID) or (Name)? ");
                        string searchParameter = Console.ReadLine();
                        if (searchParameter == "ID" || searchParameter == "id" || searchParameter == "Id")
                        {
                            Console.Write("\nEnter the employee ID to search for: ");
                            company.ViewEmployee(Convert.ToInt32(Console.ReadLine()));
                            EmployeeMenuOptions();
                        }
                        else
                        {
                            Console.Write("\nEnter the employee full name to search for: ");
                            company.ViewEmployee(Console.ReadLine());
                            EmployeeMenuOptions();
                        }
                        break;

                    case "2":
                        Console.WriteLine("List of companys departments:");
                        company.ViewDepartment();
                        Console.WriteLine("Enter ID of the company you want to display statistics from:");
                        company.ViewStatistics(Convert.ToInt32(Console.ReadLine()));
                        EmployeeMenuOptions();
                        break;

                    case "3":
                        Console.WriteLine("Display all departments:");
                        company.ViewDepartment();
                        EmployeeMenuOptions();
                        break;

                    case "10":
                        LogIn(company, employee);
                        break;

                    case "11":
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
        }

        public static void LogIn(Company company, IEmployee employee)
        {
            Console.WriteLine("Welcome to login page!!");

            Console.WriteLine("Enter user name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            var password = Console.ReadLine();

            if (name == "admin1" && password == "admin1234")
            {
                AdminView(company, employee);
            }
            else
            {
                EmployeeView(company, employee);
            }
        }
    }
}