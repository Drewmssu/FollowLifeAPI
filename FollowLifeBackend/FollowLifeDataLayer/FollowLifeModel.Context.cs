﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FollowLifeEntities : DbContext
    {
        public FollowLifeEntities()
            : base("name=FollowLifeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorMedicalSpeciality> DoctorMedicalSpeciality { get; set; }
        public virtual DbSet<Indicator> Indicator { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<MedicalSpeciality> MedicalSpeciality { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurement { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Device> Device { get; set; }
    }
}
