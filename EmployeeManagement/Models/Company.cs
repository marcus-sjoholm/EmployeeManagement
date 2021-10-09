namespace EmployeeManagement.Models
{
    using EmployeeManagement.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Company : Employee, ICompany
    {
        private readonly List<Department> departments = new List<Department>();
        private readonly List<Employee> employees = new List<Employee>();

        public int AddDepartment(string departmentName)
        {
            int i = 1;

            departments.Add(new Department(new Random().Next(1, 100), departmentName));

            Console.WriteLine();

            foreach (var department in departments)
            {
                Console.WriteLine(i + " Department ID: " + department.DepartmentID + " | Department Name: " + department.DepartmentName);
                i++;
            }

            return new Random().Next(1, 100);
        }

        public int AddEmployee(IEmployee e, out int id)
        {
            int i = 1;

            employees.Add(new Employee(e.EmployeeDepartmentID, new Random().Next(1, 1000), e.Name, e.Experience, e.Role, e.Salary));
            Console.WriteLine();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {i}");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Department: {employee.DepartmentID}");
                Console.WriteLine($"Role: {employee.Role}");
                Console.WriteLine($"Experience: {employee.Experience}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
                i++;
            }

            id = new Random().Next(1, 1000);
            return new Random().Next(1, 1000);
        }

        public int DeleteEmployee(int id)
        {
            if (employees.SingleOrDefault(r => r.EmployeeID == id) != null)
            {
                employees.Remove(employees.SingleOrDefault(r => r.EmployeeID == id));
                Console.WriteLine($"Employee {id} has been removed");
                return id;
            }
            else
            {
                return 0;
            }
        }

        public int EditEmployeeRole(int employee)
        {
            Console.WriteLine("Enter the new role of employee:");
            List<Employee> result = employees.FindAll(x => x.EmployeeID == employee);

            foreach (var empl in result)
            {
                empl.Role = Console.ReadLine();
            }
            return 0;
        }

        public int ViewDepartment()
        {
            int i = 1;
            Console.WriteLine();
            foreach (var department in departments)
            {
                Console.WriteLine($"{i} Department => ID: {department.DepartmentID} => {department.DepartmentName}");
                i++;
            }
            return 0;
        }

        public IEmployee ViewEmployee(int id)
        {
            int i = 1;
            Console.WriteLine();
            employees.Sort();

            foreach (var employee in employees.FindAll(x => x.EmployeeID == id))
            {
                Console.WriteLine($"Employee {i}");
                Console.WriteLine($"Employee ID: {employee.EmployeeID}");
                Console.WriteLine($"Department ID: {employee.DepartmentID}");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Employee Experience: {employee.Experience}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
                i++;
            }
            return null;
        }

        public IEmployee ViewEmployee(string name)
        {
            int i = 1;
            Console.WriteLine();
            employees.Sort();
            foreach (var employee in employees.FindAll(x => x.Name == name))
            {
                Console.WriteLine($"Employee {i}");
                Console.WriteLine($"Employee ID: {employee.EmployeeID}");
                Console.WriteLine($"Department ID: {employee.DepartmentID}");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Employee Experience: {employee.Experience}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
                i++;
            }
            return null;
        }

        public int ViewStatistics(int id)
        {
            int i = 1;
            employees.Sort();
            List<Employee> query = employees.FindAll(x => x.DepartmentID == id);

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee {i}");
                Console.WriteLine($"Employee ID: {employee.EmployeeID}");
                Console.WriteLine($"Department ID: {employee.DepartmentID}");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Employee Experience: {employee.Experience}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
                i++;
            }
            return 0;
        }
    }
}