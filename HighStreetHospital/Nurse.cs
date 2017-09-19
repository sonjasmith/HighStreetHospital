using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Nurse : HospitalEmployee
    {
        //Fields
        protected int numberOfPatients;

        //Properties
        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }
        }

        //Constructors
        public Nurse()
        {

        }
        public Nurse(int numberOfPatients)
        {
            this.numberOfPatients = numberOfPatients;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

