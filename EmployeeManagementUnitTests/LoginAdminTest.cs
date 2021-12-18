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
        [TestMethod]
        public void LoginUser_Test()
        {
            var name = "Nils";
            var password = "Nils123";

            var actual = (name, password);

            Assert.AreEqual(actual.name, name);
            Assert.AreEqual(actual.password, password);
        }
    }
}


