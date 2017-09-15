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
        private bool isSweeping;

        public string JanitorDepartment
        {
            get { return this.janitorDepartment; }
        }

        public bool IsSweeping
        {
            get { return this.isSweeping; }
        }

        public Janitor(string employeeName, int employeeNumber)
        {
            this.janitorDepartment = janitorDepartment;
            this.isSweeping = isSweeping;
        }
    }
}
