﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assinment_OOP03
{
    internal class Employee
    {
        #region Attribute
        //public int ID;
       // private string? Name; 
        //private int securityLevel; 
        //private decimal salary; 
        //private Date HireDate; 
       private string gender;
        #endregion
        #region properties
         public int ID { get; set; }
         public string? Name { get; set; }
        public int securityLevel { get; set; }
        public decimal salary { get; set; }
        public DateOnly HireDate { get; set; }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value=="M" ||value =="F")
                {
                    gender=value;
                }
                else { Console.WriteLine("gender must be 'F' OR 'M'"); }
            }
        }
        #endregion
        #region •Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
        public enum SecurityLevel
        {
            guest, 
            Developer,
            secretary,
            DBA
        }
        #endregion
        #region •We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()),display employee salary in a currency format. [Use String.Format() Function].
        public override string ToString()
        {
            return $"ID={ID} \n Name:{Name} \n security level={securityLevel} \n salary is{salary}\n hire date ={HireDate} \n Gender={Gender}" ;
        }
        #endregion
    }
}
