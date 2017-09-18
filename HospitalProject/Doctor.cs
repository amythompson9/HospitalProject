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

        public Doctor (string employeeName, int employeeNumber, bool isWorking, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.specialtyArea = specialtyArea;
        }

        public override void DisplayStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(isWorking + "\t");
            Console.Write(specialtyArea + "\n");
        }


    }
}
