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
        private bool isOperating;

        public string SurgeonSpecialty
        {
            get { return this.surgeonSpecialty; }
        }

        public bool IsOperating
        {
            get { return this.isOperating; }
        }

        public Surgeon (string employeeName, int employeeNumber)
        {
            this.surgeonSpecialty = surgeonSpecialty;
            this.isOperating = isOperating;
        }
    }
}
