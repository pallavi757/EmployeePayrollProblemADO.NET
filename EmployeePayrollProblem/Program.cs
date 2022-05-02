using System;
namespace EmployeePayrollProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int option = 0;
            EmpDetails empDetails = new EmpDetails();
            do
            {
            Console.WriteLine("Welcome in EmployeePayroll");
            Console.WriteLine("======================================");
            Console.WriteLine("Option 1 for Check connection ");
            Console.WriteLine("Option 2 for Get All Record For Employee ");
            Console.WriteLine("option 3 for UpDateOnly salary");
            Console.WriteLine("option 4 for Get the Emplyoee Data in Date range");
                Console.WriteLine("option 0 for Exit");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            empDetails.EstablishConnection();
                            empDetails.CloseConnection();
                            break;

                        case 2:
                            empDetails.GetAllEmployeePayrollData();
                            break;
                        case 3:
                            EmpModel empModel = new EmpModel
                            {
                                ID = 1,
                                Name = "Yogiraj",
                                BasicPay = 3000000,
                                Deductions = 10000,
                                TaxablePay = 7000,
                                IncomeTax = 5000,
                                NetPay = 2978000
                            };
                            empDetails.UpdateEmployeeSalary(empModel);
                            Console.WriteLine("Salary Updated successfully ");
                            break;
                        case 4:
                            var fromDate = Convert.ToDateTime("2022-02-04");
                            var ToDate = Convert.ToDateTime("2022-05-02");
                            empDetails.GetEmplyeeDataInDateRange(fromDate,ToDate);
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter correct option");
                }
            }

            while (option != 0);
        }

    }
}
