using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Nurse: EmployeeBase
    {
        private int numberOfPatients;

        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
        }

        public Nurse(string employeeName, int employeeNumber, bool isWorking, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.numberOfPatients = numberOfPatients;
        }

        public override void DisplayStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(numberOfPatients + "\n");
        }
    }
}
