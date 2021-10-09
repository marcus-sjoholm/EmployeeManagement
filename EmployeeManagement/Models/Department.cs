namespace EmployeeManagement.Models
{
    using Interfaces;

    internal class Department : IDepartment
    {
        public Department()
        {
            DepartmentID = 0;
            DepartmentName = null;
        }

        public Department(int departmentID, string departmentName)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
        }

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}