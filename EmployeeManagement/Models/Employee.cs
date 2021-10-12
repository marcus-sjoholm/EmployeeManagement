namespace EmployeeManagement.Models
{
    using Interfaces;
    using System.ComponentModel.DataAnnotations.Schema;

    internal class Employee : Department, IEmployee
    {
        public Employee()
        {
            EmployeeDepartmentID = 0;
            EmployeeID = 0;
            Name = null;
            Experience = 0;
            Role = null;
            Salary = 0;
            Password = null;
        }

        public Employee(int employeeDepartmentID, int employeeID, string fullName, int experience, string role, int salary, string password)
        {
            EmployeeDepartmentID = employeeDepartmentID;
            EmployeeID = employeeID;
            Name = fullName;
            Experience = experience;
            Role = role;
            Salary = salary;
            Password = password;
        }

        public int EmployeeDepartmentID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        public int Experience { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
    }
}