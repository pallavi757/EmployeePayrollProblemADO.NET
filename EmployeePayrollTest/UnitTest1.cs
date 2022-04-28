using EmployeePayrollProblem;
using NUnit.Framework;

namespace EmployeePayrollTest
{
    public class Tests
    {
        EmpDetails empDetails;
        [SetUp]
        public void Setup()
        {
            empDetails = new EmpDetails();
        }

        [Test]
        /// <summary>
        /// UC2 - Get the all Employee Payroll Data
        /// </summary>
     
        public void Get_AllEmployeePayrollData()
        {
            var actual = empDetails.GetAllEmployeePayrollData();
            Assert.AreEqual(3, actual.Count);
        }
    }
}