using System;
namespace EmployeePayrollProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in EmployeePayroll");
            EmpDetails empDetails = new EmpDetails();
            empDetails.EstablishConnection();
            empDetails.CloseConnection();
        }
    }
}