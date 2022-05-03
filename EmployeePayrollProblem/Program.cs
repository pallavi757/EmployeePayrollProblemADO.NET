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
            Console.WriteLine("option 5 for Add the Employee Data");
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
                        case 5:
                            EmpModel emp = new EmpModel();
                            Console.WriteLine("Enter The Name");
                            string name = Console.ReadLine();
                            emp.Name = name;
                            Console.WriteLine(" Emplyoee Join Date");
                            string date = Console.ReadLine();
                            emp.StartDate = Convert.ToDateTime(date);
                            Console.WriteLine("Enter a Gender");
                            string gender = Console.ReadLine();
                            emp.Gender = gender;
                            Console.WriteLine("Enter Phone number");
                            double Phone = Convert.ToInt64(Console.ReadLine());
                            emp.Phone = Phone;
                            Console.WriteLine("Enter a Address");
                            string address = Console.ReadLine();
                            emp.Address = address;
                            Console.WriteLine("Enter a Department");
                            string department = Console.ReadLine();
                            emp.Department = department;
                            Console.WriteLine("Enter a Basic Pay");
                            double basicpay = Convert.ToInt64(Console.ReadLine());
                            emp.BasicPay = basicpay;
                            Console.WriteLine("Enter a Deduction");
                            int Deduction = int.Parse(Console.ReadLine());
                            emp.Deductions = Deduction;
                            Console.WriteLine("Enter a Taxable Pay");
                            int taxablepay = int.Parse(Console.ReadLine());
                            emp.TaxablePay = taxablepay;
                            Console.WriteLine("Enter a Income Tax");
                            int incometax = int.Parse(Console.ReadLine());
                            emp.IncomeTax = incometax;
                            Console.WriteLine("Enter a NetPay");
                            int netpay = int.Parse(Console.ReadLine());
                            emp.NetPay = netpay;
                            empDetails.AddEmployee(emp);
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
