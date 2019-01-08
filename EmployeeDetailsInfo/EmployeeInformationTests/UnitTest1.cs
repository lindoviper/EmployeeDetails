using System;
using Xunit;
using EmployeeDetailsInfo.Repository;
using System.IO;

namespace EmployeeInformationTests
{
    public class EmployeeInformationTests
    {
        [Fact]
        public void WhenRequestingAllEmployees_ReturnFriendlyExceptionMessageIfFileDoesnotExist()
        {
            var repo = new EmployeeDataRepository();
            Assert.Throws<FileNotFoundException>(() => repo.GetEmployeeInformation());
        }

    }
}
