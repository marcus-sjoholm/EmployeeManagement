using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagementUnitTests
{
    [TestClass]
    public class LoginAdminTest
    {
        [TestMethod]
        public void LoginAdmin_Test()
        {
            var name = "admin1";
            var password = "Admin1234";

            var actual = (name, password);

            Assert.AreEqual(actual.name, name);
            Assert.AreEqual(actual.password, password);
        }
    }
}


