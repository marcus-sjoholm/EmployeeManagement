namespace EmployeeManagement.Collection
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Sqlite;
    using System.Linq;

    internal class Employee
    {
        //public string Employee_Adress { get; set; }
        //public int Employee_Id { get; set; }
        //public string Employee_Name { get; set; }
        //public string Employee_Position { get; set; }
        //public string Employee_Salary { get; set; }
        public static bool AddNewEmployeeToDb()
        {
            try
            {
                using var db = new Database.DatabaseFilePath();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex);
            }
        }

        public static void AdminAccess()
        {
            var employeeList = new List<Company>();
            char answer;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. View employee details");
                Console.WriteLine("3. Search employee details");
                Console.WriteLine("4. Modify employee details");
                Console.WriteLine("5. Remove employee details");
                Console.WriteLine("6. Set employee salary");
                Console.WriteLine("7. Display salary");
                Console.WriteLine("10. Log out");
                Console.WriteLine("11. Exit");
                Console.Write("\nEnter Your Choise Here: ");

                int searchQuery;
                var backend = new Backend();
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        backend.AddNewEmployee(employeeList);
                        backend.DisplayEmployeeInformation(employeeList);
                        break;

                    case 2:
                        backend.DisplayEmployeeInformation(employeeList);
                        break;

                    case 3:
                        Console.WriteLine("Enter employee ID which you want to search:");
                        searchQuery = Convert.ToInt32(Console.ReadLine());
                        if (backend.Search(employeeList, searchQuery) != null)
                        {
                            Console.WriteLine("Employee ID: ", backend.Search(employeeList, searchQuery).Employee_Id);
                            Console.WriteLine("Employee Name: ", backend.Search(employeeList, searchQuery).Employee_Name);
                            Console.WriteLine("Employee Adress: ", backend.Search(employeeList, searchQuery).Employee_Adress);
                            Console.WriteLine("Position: ", backend.Search(employeeList, searchQuery).Employee_Position);
                        }
                        else
                        {
                            Console.WriteLine("Search didn´t find anything");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter employee ID which you want to search:");
                        searchQuery = Convert.ToInt32(Console.ReadLine());
                        if (backend.Search(employeeList, searchQuery) != null)
                        {
                            Console.WriteLine("Employee ID :" + backend.Search(employeeList, searchQuery).Employee_Id);
                            Console.WriteLine("Employee Name :" + backend.Search(employeeList, searchQuery).Employee_Name);
                            Console.WriteLine("Employee Adress :" + backend.Search(employeeList, searchQuery).Employee_Adress);
                            Console.WriteLine("Position :" + backend.Search(employeeList, searchQuery).Employee_Position);
                            backend.ModifyEmployee(backend.Search(employeeList, searchQuery));
                            backend.DisplayEmployeeInformation(employeeList);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }

                        break;

                    case 5:
                        Console.WriteLine("Enter employee ID which you want to search:");
                        searchQuery = Convert.ToInt32(Console.ReadLine());
                        if (backend.Search(employeeList, searchQuery) != null)
                        {
                            Console.WriteLine("Employee ID :" + backend.Search(employeeList, searchQuery).Employee_Id);
                            Console.WriteLine("Employee Name :" + backend.Search(employeeList, searchQuery).Employee_Name);
                            Console.WriteLine("Employee Adress :" + backend.Search(employeeList, searchQuery).Employee_Adress);
                            Console.WriteLine("Position :" + backend.Search(employeeList, searchQuery).Employee_Position);
                            backend.RemoveEmployee(employeeList, backend.Search(employeeList, searchQuery));
                            backend.DisplayEmployeeInformation(employeeList);
                        }
                        else
                        {
                            Console.WriteLine("Search didn´t return any result");
                        }
                        break;

                    case 6:
                        SetSalary();
                        break;

                    case 7:
                        DisplaySalary();
                        break;

                    case 10:
                        Backend.LogIn();
                        break;

                    case 11:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
                Console.Write("Would you like to continue(Y/N):");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer == 'y' || answer == 'Y');
        }

        public static void DisplayCurrentPosition()
        {
        }

        public static void DisplaySalary()
        {
        }

        public static void EmployeeAccess()
        {
            _ = new Backend();
            _ = new List<Company>();
            char answer;
            do
            {
                Console.Clear();

                Console.WriteLine("1. Display Salary");
                Console.WriteLine("2. Display your position in company");
                Console.WriteLine("3. Request change of position");
                Console.WriteLine("4. Request change of salary");
                Console.WriteLine("10. Log out");
                Console.WriteLine("11. Exit");
                Console.Write("\nEnter Your Choise Here: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        DisplaySalary();
                        break;

                    case 2:
                        DisplayCurrentPosition();
                        break;

                    case 3:
                        RequestNewPosition();
                        break;

                    case 4:
                        RequestNewSalary();
                        break;

                    case 10:
                        Backend.LogIn();
                        break;

                    case 11:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.Write("Start a new search? (Y/N):");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer == 'y' || answer == 'Y');
        }

        public static void RequestNewPosition()
        {
        }

        public static void RequestNewSalary()
        {
        }

        public static void SetSalary()
        {
        }

        public void AddNewEmployee(List<Company> employeeList)
        {
            Console.Write("Enter Employee Name:");
            new Company().Employee_Name = Console.ReadLine();
            Console.Write("Enter Employee Addess:");
            new Company().Employee_Adress = Console.ReadLine();
            Console.Write("Enter Employee Position:");
            new Company().Employee_Position = Console.ReadLine();

            employeeList.Add(new Company());
            Console.WriteLine("\nEmployee was successfully added to the system");
        }

        public void DisplayEmployeeInformation(List<Company> employeeList)
        {
            Console.WriteLine("Employee Details:\n");
            foreach (Company employee in employeeList)
            {
                Console.WriteLine("\nEmployee Id: "
                                  + employee.Employee_Id
                                  + "\nEmployee Name :"
                                  + employee.Employee_Name
                                  + "\nEmployee Addess:"
                                  + employee.Employee_Adress
                                  + "\nEmployee Position: "
                                  + employee.Employee_Position);
            }
        }

        public void ModifyEmployee(Company modify)
        {
            Console.WriteLine("Chose Option for Modify Employee Detail:");
            Console.WriteLine("1.Id 2.Name 3.Adress 4.");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter New Employee Id:");
                    modify.Employee_Id = Convert.ToInt32(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter New Employee Name:");
                    modify.Employee_Name = Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Enter New Employee Adress:");
                    modify.Employee_Adress = Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Enter New Employee Designation:");
                    modify.Employee_Position = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public void RemoveEmployee(List<Company> employeeList, Company modify)
        {
            employeeList.Remove(modify);
            Console.WriteLine("Removed successfully");
        }

        public Company Search(List<Company> employeeList, int search_Id)
        {
            return employeeList.Find(employeeId => employeeId.Employee_Id == search_Id);
        }
    }
}