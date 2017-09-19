using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class HospitalEmployee
    {
        //Fields
        protected string employeeName;
        protected int employeeNumber;
        protected string strEmployeeNumber;
        protected string occupation;
                
        //protected int numberOfPatients;
        //string specialtyArea;
        //protected string department;
        //protected bool isOnPhone;
        //protected bool isSweeping;

        //Properties
        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }
        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
            set { this.employeeNumber = value; }
        }
        public string StrEmployeeNumber
        {
            get { return this.strEmployeeNumber; }
            set { this.strEmployeeNumber = value; }
        }
        public string Occupation
        {
            get { return this.occupation; }
            set { this.occupation = value; }
        }
        //public int NumberOfPatients
        //{
        //    get { return this.numberOfPatients; }
        //    set { this.numberOfPatients = value; }
        //}
       
        //public string Department
        //{
        //    get { return this.department; }
        //    set { this.department = value; }
        //}
        //public bool IsOnPhone
        //{
        //    get { return this.isOnPhone; }
        //    set { this.isOnPhone = value; }
        //}
        //public bool IsSweeping
        //{
        //    get { return this.isSweeping; }
        //    set { this.isSweeping = value; }
        //}

        //Constructors
        public HospitalEmployee()
        {

        }
        public HospitalEmployee(string employeeName, int employeeNumber, string occupation)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.occupation = occupation;
           // this.strEmployeeNumber = strEmployeeNumber;
            //this.numberOfPatients = numberOfPatients;
            //this.specialtyArea = specialtyArea;
            //this.department = department;
            //this.isOnPhone = isOnPhone;
            //this.isSweeping = isSweeping;
        }

        //Methods

    }
}
