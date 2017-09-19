using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Administrator : HospitalEmployee
    {
        //Fields
        protected string department;
        
        //Properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        
        //Constructors
        public Administrator()
        {

        }
        public Administrator(string employeeName, int employeeNumber, string department)
        {
            this.department = department;
        }

        //Methods
    }
}
