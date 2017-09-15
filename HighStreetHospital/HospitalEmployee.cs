using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class HospitalEmpoyee
    {
        //Fields
        protected string employeeName;
        protected int employeeNumber;
        protected int numberOfPatients;
        protected string specialtyArea;
        protected string department;
        protected bool isOnPhone;
        protected bool isSweeping;

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
        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }
        }
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }
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
        public bool IsSweeping
        {
            get { return this.isSweeping; }
            set { this.isSweeping = value; }
        }

        //Constructors
        public HospitalEmpoyee()
        {

        }
        public HospitalEmpoyee()
    }
}
