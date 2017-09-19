using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Receptionist : HospitalEmployee
    {
        //Fields
        protected string department;
        protected bool isOnPhone;

        //Properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public bool IsOnPhone
        {
            get { return this.isOnPhone; }
            set { this.isOnPhone = value; }
        }
              
        //Constructors
        public Receptionist()
        {

        }
        public Receptionist(string department, bool isOnPhone)
        {
            this.department = department;
            this.isOnPhone = isOnPhone;
        }

        //Methods
    }
}
