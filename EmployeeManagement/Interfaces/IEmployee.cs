namespace EmployeeManagement.Interfaces
{
    public interface IEmployee
    {
        int EmployeeDepartmentID { get; set; }
        int EmployeeID { get; set; }
        int Experience { get; set; }
        string Name { get; set; }
        string Role { get; set; }
        int Salary { get; set; }
    }
}