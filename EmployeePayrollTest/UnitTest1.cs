using EmployeePayrollProblem;
using NUnit.Framework;
using System;

namespace EmployeePayrollTest
{
    public class Tests
    {
        EmpDetails empDetails;
        EmpModel empModel;
        //Program program;
        [SetUp]
        public void Setup()
        {
            empDetails = new EmpDetails();
            empModel = new EmpModel();
           // program = new Program();
        }

        [Test]
        /// <summary>
        /// TC2 - Get the all Employee Payroll Data
        /// </summary>
     
        public void Get_AllEmployeePayrollData()
        {
            var actual = empDetails.GetAllEmployeePayrollData();
            Assert.AreEqual(3, actual.Count);
        }
        /// <summary>
        /// TC3 - Update the Salary of Emplyoee
        /// </summary>
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
        /// <summary>
        ///TC5-Get Employee Data In Date Range
        ///</summary>
        [Test]
        public void Given_DateRange_GetEmployeePayrollData()
        {
            bool expected = true;
            var fromDate = Convert.ToDateTime("2022-02-04");
            var ToDate = Convert.ToDateTime("2022-05-02");
            bool result = empDetails.GetEmplyeeDataInDateRange(fromDate, ToDate);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// TC7-Add the Employee Data 
        /// </summary>
        [Test]
        public void AddEmployeeData()
        {
            bool expected = true;
            empModel.Name = "Nikita";
            empModel.StartDate = Convert.ToDateTime("2022-03-09");
            empModel.Gender = "F";
            empModel.Phone = 889900766;
            empModel.Address = "Pune";
            empModel.Department = "IT";
            empModel.BasicPay = 40000;
            empModel.Deductions = 1000;
            empModel.TaxablePay = 1000;
            empModel.IncomeTax = 1000;
            empModel.NetPay = 37000;
            bool result = empDetails.AddEmployee (empModel);
            Assert.AreEqual(expected, result);
        }
    }
}