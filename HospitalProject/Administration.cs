using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Administration: EmployeeBase
    {
        private string adminDepartment;

        public string AdminDepartment
        {
            get { return this.adminDepartment; }
        }

        public Administration(string employeeName, int employeeNumber)
        {
            this.adminDepartment = adminDepartment;
        }
    }
}
