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
