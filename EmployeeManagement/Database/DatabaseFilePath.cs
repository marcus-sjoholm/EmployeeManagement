namespace HusrumProject.Database
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.IO;

    internal class DatabaseFilePath : DbContext
    {
        private static string DatabaseFile { get; set; } = "EmployeeManagementDataBase.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (path != null)
                {
                    path = Path.Combine(path, "EmployeeDatabase");
                    Directory.CreateDirectory(path);
                    path = Path.Combine(path, DatabaseFile);
                    optionsBuilder.UseSqlite("Data source = " + path + ";");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception ", ex);
            }
        }
    }
}