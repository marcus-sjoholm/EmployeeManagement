using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EmployeeManagementUnitTests
{
    [TestFixture]
    public class DepartmentTest
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }
    }
}