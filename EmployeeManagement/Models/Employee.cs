namespace EmployeeManagement.Models
{
    using Interfaces;

    internal class Employee : Department, IEmployee
    {
        public Employee()
        {
            EmployeeDepartmentID = EmployeeDepartmentID;
            EmployeeID = 0;
            Name = null;
            Experience = 0;
            Role = null;
            Salary = 0;
        }

        public Employee(int employeeDepartmentID, int employeeID, string fullName, int experience, string role, int salary)
        {
            EmployeeDepartmentID = employeeDepartmentID;
            EmployeeID = employeeID;
            Name = fullName;
            Experience = experience;
            Role = role;
            Salary = salary;
        }

        public int EmployeeDepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public int Experience { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
    }
}