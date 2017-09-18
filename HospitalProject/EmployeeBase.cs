using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class EmployeeBase
    {
        protected string employeeName;
        protected int employeeNumber;
        protected bool isWorking;

        public string EmployeeName
        {
            get { return this.employeeName; }
        }
        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        public bool IsWorking
        {
            get { return this.isWorking; }
        }

        public EmployeeBase()
        {

        }

        public EmployeeBase(string employeeName, int employeeNumber, bool isWorking)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
        }

        public virtual void DisplayStatus()
        {

        }

        public virtual void DisplayWorking()
        {

        }




        //Michael 234 Heart
        //Vincent 645 Brain       true
        //Sonny   789 6
        //Luca    375 Business
        //Tom 951 Office      true
        //Anthony 123 Maintenence false
    }
}
