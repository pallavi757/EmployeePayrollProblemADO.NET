﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollProblem
{
    public class EmpExceptioncs:Exception
    {
        ExceptionType exceptionType;
        public enum ExceptionType
        {
            Connection_Failed
        }
        public EmpExceptioncs(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
