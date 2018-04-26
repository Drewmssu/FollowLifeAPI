//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FollowLifeDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int Id { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public Nullable<System.DateTime> CanceledAt { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
