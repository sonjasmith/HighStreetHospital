using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Surgeon : HospitalEmployee
    {
        //Fields
        private string specialtyAreaHeart;
        private bool isOperating;

        //Properties 
        public string SpecialtyAreaHeart
        {
            get { return this.specialtyAreaHeart; }
            set { this.specialtyAreaHeart = value; }
        }
        public bool IsOperating
        {
            get { return this.isOperating; }
            set { this.isOperating = value; }
        }
        //Constructors
        public Surgeon()
        {

        }
        public Surgeon(string specialtyAreaHeart, bool isOperating)
        {
            this.specialtyAreaHeart = specialtyAreaHeart;
            this.isOperating = isOperating;
        }

        //Methods //the virtual keyword gives the derived class the 
        //option to override the specific method
        //public virtual void ()

    }
}


