//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBM_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoctorsThatDontHaveAppointmentToday
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
        public int AddressID { get; set; }
        public int DiseaseID { get; set; }
    }
}
