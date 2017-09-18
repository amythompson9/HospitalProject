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

        public Administration(string employeeName, int employeeNumber, bool isWorking, string adminDepartment)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.adminDepartment = adminDepartment;
        }

        public override void DisplayStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(isWorking + "\t");
            Console.Write(adminDepartment + "\n");
        }
    }
}
