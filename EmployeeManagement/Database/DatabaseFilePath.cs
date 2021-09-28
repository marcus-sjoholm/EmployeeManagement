namespace HusrumProject.Database
{
    using Microsoft.EntityFrameworkCore;

    internal class DatabaseFilePath : DbContext
    {
        private static string DatabaseFile { get; } = "EmployeeManagementDataBase.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}