using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Surgeon: EmployeeBase
    {
        private string surgeonSpecialty;

        public string SurgeonSpecialty
        {
            get { return this.surgeonSpecialty; }
        }


        public Surgeon (string employeeName, int employeeNumber, bool isWorking, string surgeonSpecialty)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.surgeonSpecialty = surgeonSpecialty;
        }

        public override void DisplayStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(isWorking + "\t");
            Console.Write(surgeonSpecialty + "\n");
        }

        public override void DisplayWorking()
        {
            if (isWorking == true)
            {
                Console.WriteLine(employeeName + " is operating now.");
            }
            else
            {
                Console.WriteLine(employeeName + " is not operating now.");
            }
        }
    }
}
