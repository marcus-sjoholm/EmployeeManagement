namespace EmployeeManagement.Models
{
    using EmployeeManagement.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    internal class Company : Employee, ICompany
    {
        private readonly List<Department> departments = new List<Department>();
        private readonly List<Employee> employees = new List<Employee>();

        public int AddDepartment(string departmentName)
        {
            var i = 1;

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
            var i = 1;

            Random random = new Random();
            var rnd = random.Next(1, 1000);

            employees.Add(new Employee(e.EmployeeDepartmentID, rnd, e.Name, e.Experience, e.Role, e.Salary, e.Password));
            Console.WriteLine();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {i}");
                Console.WriteLine($"Department: {employee.EmployeeDepartmentID}");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Role: {employee.Role}");
                Console.WriteLine($"Experience: {employee.Experience}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine($"Password: { employee.Password}");
                Console.WriteLine();
                i++;
            }

            id = rnd;
            return rnd;
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

        public IEmployee DisplayEmployees()
        {
            Console.WriteLine();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Role} => ID: {employee.EmployeeID} => Name: {employee.Name}");
            }
            return null;
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
            var i = 1;
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
            var i = 1;
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
            var i = 1;
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
            var i = 1;
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