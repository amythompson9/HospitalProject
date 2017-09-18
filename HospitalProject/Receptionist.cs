using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Receptionist: EmployeeBase
    {
        private string receptionistDepartment;

        public string ReceptionistDepartment
        {
            get { return this.receptionistDepartment; }
        }

        public Receptionist(string employeeName, int employeeNumber, bool isWorking, string receptionistDepartment)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.receptionistDepartment = receptionistDepartment;
        }

        public override void DisplayStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(isWorking + "\t");
            Console.Write(receptionistDepartment + "\n");
        }

        public override void DisplayWorking()
        {
            if (isWorking == true)
            {
                Console.WriteLine(employeeName + " is on the phone now.");
            }
            else
            {
                Console.WriteLine(employeeName + " is not on the phone.");
            }
        }
    }
}
