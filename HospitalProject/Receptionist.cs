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
        private bool onPhone;

        public string ReceptionistDepartment
        {
            get { return this.receptionistDepartment; }
        }

        public bool OnPhone
        {
            get { return this.onPhone; }
        }

        public Receptionist(string employeeName, int employeeNumber)
        {
            this.receptionistDepartment = receptionistDepartment;
            this.onPhone = onPhone;
        }
    }
}
