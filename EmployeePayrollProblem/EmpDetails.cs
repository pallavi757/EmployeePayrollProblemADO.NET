using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollProblem
{
     public class EmpDetails
    {
           static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeePayroll;Integrated Security=True;";
            static SqlConnection sqlconnection = new SqlConnection(connectionString);
            public void EstablishConnection()
            {
                if (sqlconnection != null && sqlconnection.State.Equals(ConnectionState.Closed))
                {
                    try
                    {
                        sqlconnection.Open();
                    }
                    catch (Exception)
                    {
                        throw new EmpExceptioncs(EmpExceptioncs.ExceptionType.Connection_Failed, "connection failed");

                    }
                }
            }
            public void CloseConnection()
            {
                if (sqlconnection != null && sqlconnection.State.Equals(ConnectionState.Open))
                {
                    try
                    {
                        sqlconnection.Close();
                    }
                    catch (Exception)
                    {
                        throw new EmpExceptioncs(EmpExceptioncs.ExceptionType.Connection_Failed, "connection failed");
                    }
                }
            }
        public  List<EmpModel> GetAllEmployeePayrollData()
        {
            List<EmpModel> empPayrollList = new List<EmpModel>();
            EmpModel empModel = new EmpModel();
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            string Spname = "dbo.GetAllEmployeePayrollData";
            using (sqlconnection)
            {
                SqlCommand sqlCommand = new SqlCommand(Spname, sqlconnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlconnection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        empModel.ID = dr.GetInt32(0);
                        empModel.Name = dr.GetString(1);
                        empModel.StartDate = dr.GetDateTime(2).Date;
                        empModel.Gender = (dr.GetString(3));
                        empModel.Phone = dr.IsDBNull(4) ? 0 : dr.GetInt64(4);
                        empModel.Address = dr.IsDBNull(5) ? "" : dr.GetString(5);
                        empModel.Department = dr.GetString(6);
                        empModel.BasicPay = dr.IsDBNull(7) ? 0 : dr.GetInt64(7);
                        empModel.Deductions = dr.IsDBNull(8) ? 0 : dr.GetInt32(8);
                        empModel.TaxablePay = dr.IsDBNull(9) ? 0 : dr.GetInt32(9);
                        empModel.IncomeTax = dr.IsDBNull(10) ? 0 : dr.GetInt32(10);
                        empModel.NetPay = dr.IsDBNull(11) ? 0 : dr.GetInt32(11);
                        empPayrollList.Add(empModel);
                        Console.WriteLine(empModel.ID + "," + empModel.Name + "," + empModel.StartDate + "," + empModel.Gender + "," + empModel.Phone + ","
                            + empModel.Address + "," + empModel.Department + "," + empModel.BasicPay + "," + empModel.Deductions + "," + empModel.TaxablePay + "," + empModel.IncomeTax + "," + empModel.NetPay);
                    }
                }
                sqlconnection.Close();
            }
            return empPayrollList;
        }
    }
    }


