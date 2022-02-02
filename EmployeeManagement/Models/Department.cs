namespace EmployeeManagement.Models
{
    using Interfaces;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Department : IDepartment
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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }
    }
}