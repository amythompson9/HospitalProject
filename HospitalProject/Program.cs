using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("High St. Hospital Employees");
            Doctor doc1 = new Doctor("Michael", 234, false, "Heart");
            Surgeon surgeon1 = new Surgeon("Vincent", 645, true, "Brain");
            Nurse nurse1 = new Nurse("Sonny", 789, false,  6);
            Administration admin1 = new Administration("Luca", 375, false,  "Business");
            Receptionist reception1 = new Receptionist("Tom", 951, true, "Office");
            Janitor janitor1 = new Janitor("Anthony", 123, false, "Maintenance");

            doc1.DisplayStatus();
            surgeon1.DisplayStatus();
            nurse1.DisplayStatus();
            admin1.DisplayStatus();
            reception1.DisplayStatus();
            janitor1.DisplayStatus();
            Console.WriteLine();
            surgeon1.DisplayWorking();
            reception1.DisplayWorking();
            janitor1.DisplayWorking();


            
            
            
            //Michael 234 Heart
            //Vincent 645 Brain       true
            //Sonny   789 6
            //Luca    375 Business
            //Tom 951 Office      true
            //Anthony 123 Maintenence false

            //Vincent is operating now.
            //Tom is on the phone now.
            //Anthony is not sweeping now.
        }
    }
}
