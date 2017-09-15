using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Doctor: EmployeeBase
    {
        private string specialtyArea;
        
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
        }

        public Doctor (string employeeName, int employeeNumber)
        {
            this.specialtyArea = specialtyArea;
        }
    }
}
