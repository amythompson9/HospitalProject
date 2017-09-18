using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Janitor: EmployeeBase
    {
        private string janitorDepartment;

        public string JanitorDepartment
        {
            get { return this.janitorDepartment; }
        }

        public Janitor(string employeeName, int employeeNumber,bool isWorking, string janitorDepartment)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.janitorDepartment = janitorDepartment;
        }

        public override void DisplayStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(isWorking + "\t");
            Console.Write(janitorDepartment + "\n");
        }

        public override void DisplayWorking()
        {
            if (isWorking == true)
            {
                Console.WriteLine(employeeName + " is sweeping now.");
            }
            else
            {
                Console.WriteLine(employeeName + " is not sweeping now.");
            }
        }
    }
}
