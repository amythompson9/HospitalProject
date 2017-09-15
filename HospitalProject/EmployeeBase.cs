using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class EmployeeBase
    {
        protected string employeeName;
        protected int employeeNumber;

        public string EmployeeName
        {
            get { return this.employeeName; }
        }
        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        public EmployeeBase()
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }


        
    }
}
