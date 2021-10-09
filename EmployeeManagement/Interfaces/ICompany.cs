namespace EmployeeManagement.Interfaces
{
    public interface ICompany
    {
        public int AddDepartment(string deptName);

        public int AddEmployee(IEmployee e, out int id);

        public int DeleteEmployee(int id);

        public int EditEmployeeRole(int employee);

        public int ViewDepartment();

        public IEmployee ViewEmployee(int id);

        public IEmployee ViewEmployee(string name);

        public int ViewStatistics(int id);
    }
}