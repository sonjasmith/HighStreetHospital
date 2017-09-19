using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Janitor : HospitalEmployee
    {
        //Fields
        protected string department;
        protected bool isSweeping;

        //Properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public bool IsSweeping
        {
            get { return this.isSweeping; }
            set { this.isSweeping = value; }
        }

        //Constructors
        public Janitor()
        {

        }
        public Janitor(string department, bool isSweeping)
        {
            this.department = department;
            this.isSweeping = isSweeping;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
