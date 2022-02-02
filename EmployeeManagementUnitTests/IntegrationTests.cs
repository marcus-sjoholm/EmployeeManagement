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
        [TestMethod]
        public void AddDepartment_Test()
        {
            var newCompany = new Company();
            newCompany.AddDepartment(newCompany.DepartmentName = "New Department");
            Assert.IsNotNull(newCompany);
            Assert.AreEqual("New Department", newCompany.DepartmentName);
        }
        [TestMethod]
        public void DeleteDepartment_Test()
        {
            var newCompany = new Company();
            var newDepartment = new Department();

            newCompany.AddDepartment(newDepartment.DepartmentName = "New Department to remove");

            Assert.IsNotNull(newDepartment);
            Assert.AreEqual("New Department to remove", newDepartment.DepartmentName);

            newCompany.DeleteDepartment(newDepartment.DepartmentName = null);

            Assert.AreEqual(newDepartment.DepartmentName, null);

        }
    }
}