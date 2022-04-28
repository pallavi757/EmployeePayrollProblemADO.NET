using EmployeePayrollProblem;
using NUnit.Framework;

namespace EmployeePayrollTest
{
    public class Tests
    {
        EmpDetails empDetails;
        //Program program;
        [SetUp]
        public void Setup()
        {
            empDetails = new EmpDetails();
           // program = new Program();
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
        /// UC 3 - Update the Salary of Emplyoee
        [Test]
        public void UpdateEmployeeSalary_ShouldReturn_True_AfterUpdate()
        {
            bool expected = true;
            EmpModel empModel = new EmpModel();
            empModel.ID = 1;
            empModel.Name = "Yogiraj";
            empModel.BasicPay = 3000000;
            empModel.Deductions = 10000;
            empModel.TaxablePay = 7000;
            empModel.IncomeTax = 5000;
            empModel.NetPay = 2978000;
            bool result = empDetails.UpdateEmployeeSalary(empModel);
            Assert.AreEqual(expected, result);
        }
    }
}