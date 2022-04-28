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
        }
    }


