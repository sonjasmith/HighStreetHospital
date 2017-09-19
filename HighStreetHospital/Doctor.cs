using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Doctor : HospitalEmployee
    {
        //Fields
        protected string specialtyAreaFoot;

        //Properties 
        public string SpecialtyAreaFoot
        {
            get { return this.specialtyAreaFoot; }
            set { this.specialtyAreaFoot = value; }
        }

        //Constructors
        public Doctor()
        {

        }
        public Doctor(string specialtyAreaFoot)
        {
            this.specialtyAreaFoot = specialtyAreaFoot;
        }

        //Methods //the virtual keyword gives the derived class the 
        //option to override the specific method
        //public virtual void ()

        //{
        //    Console.WriteLine(employeeName);
        //}
        
    }
}
