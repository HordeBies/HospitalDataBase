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
    
    public partial class PatientsWaitingAppointment
    {
        public int ID { get; set; }
        public string Full_Name { get; set; }
        public int DiseaseID { get; set; }
        public int AppointmentID { get; set; }
        public System.DateTime Appointment_Date { get; set; }
    }
}