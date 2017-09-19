using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericEmployee employee0 = new GenericEmployee();
            //employee0.EmployeeName = "Name";
            //employee0.StrEmployeeNumber = "ID No.";
            Console.WriteLine("High Street Employees:\n ");
            Console.WriteLine("EMPL NAME\t" + "ID No.\t" + "OCCUPATION\t" + "SPECIALTY\t" +
                "DEPARTMENT\t" + "CURRENTLY DOING SOMETHING\t");

            Doctor employee1 = new Doctor();
            employee1.EmployeeName = "Dave\t\t";
            employee1.EmployeeNumber = 345;
            employee1.SpecialtyAreaFoot = "\t\t\tFoot";
            Console.WriteLine(employee1.EmployeeName + " " + employee1.EmployeeNumber
                + " " + employee1.SpecialtyAreaFoot);

            Surgeon employee2 = new Surgeon();
            employee2.EmployeeName = "Joan\t\t";
            employee2.EmployeeNumber = 128;
            employee2.SpecialtyAreaHeart = "\t\t\tHeart";
            Console.WriteLine(employee2.EmployeeName + " " + employee2.EmployeeNumber
                + " " + employee2.SpecialtyAreaHeart + "\t\t\t\t" + employee2.IsOperating);

            Nurse employee3 = new Nurse();
            employee3.EmployeeName = "Diane\t\t";
            employee3.EmployeeNumber = 298;
            employee3.NumberOfPatients = 6;
            Console.WriteLine(employee3.EmployeeName + " " + employee3.EmployeeNumber
                + " ");

            Administrator employee4 = new Administrator();
            employee4.EmployeeName = "Tanya\t\t";
            employee4.EmployeeNumber = 982;
            employee4.Occupation = "Administrator";
            employee4.Department = "\t\t\tCardiology";
            Console.WriteLine(employee4.EmployeeName + " " + employee4.EmployeeNumber + "\t"
                + employee4.Occupation + employee4.Department);

            Receptionist employee5 = new Receptionist();
            employee5.EmployeeName = "Jami\t\t";
            employee5.EmployeeNumber = 610;
            employee5.Occupation = "Receptionist";
            employee5.Department = "\t\t\tOncology";
            employee5.IsOnPhone = true;
            Console.WriteLine(employee5.EmployeeName + " " + employee5.EmployeeNumber + "\t"
                + employee5.Occupation + employee5.Department + "\t" + employee5.IsOnPhone);

            Janitor employee6 = new Janitor();
            employee6.EmployeeName = "Dann\t\t";
            employee6.EmployeeNumber = 923;
            employee6.Occupation = "Janitor";
            employee6.Department = "\t\t\tMaintenance";
            employee6.IsSweeping = true;
            Console.WriteLine(employee6.EmployeeName + " " + employee6.EmployeeNumber + "\t"
                + employee6.Occupation + " " + employee6.Department + "\t" + employee6.IsSweeping);

            //getPaid();

        }
    }
}
