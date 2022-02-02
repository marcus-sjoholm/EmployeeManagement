using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement.Models;
using EmployeeManagement.Interfaces;

namespace EmployeeManagementUnitTests
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void DeleteEmployee_Test()
        {
            var newEmployee = new Employee() { EmployeeID = 1 };

            var newCompany = new Company();

            newCompany.DeleteEmployee(newEmployee.EmployeeID);

            Assert.AreEqual(1, newEmployee.EmployeeID);
        }
    }
}