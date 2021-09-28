namespace EmployeeManagement
{
    namespace Collection
    {
        public class Company : ICompany
        {
            public string Employee_Adress { get; set; }
            public int Employee_Id { get; set; }
            public string Employee_Name { get; set; }
            public string Employee_Position { get; set; }
        }
    }

    namespace Collection
    {
        internal static class Program
        {
            private static void Main()
            {
                Backend.LogIn();
            }
        }
    }
}