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

        public Nurse(string employeeName, int employeeNumber)
        {
            this.numberOfPatients = numberOfPatients;
        }
    }
}
