﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _23092019_dotNet2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_Hospital : DbContext
    {
        public DB_Hospital()
            : base("name=DB_Hospital")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_CustomerBooking> tbl_CustomerBooking { get; set; }
        public virtual DbSet<tbl_Group> tbl_Group { get; set; }
        public virtual DbSet<tbl_MedicalBill> tbl_MedicalBill { get; set; }
        public virtual DbSet<tbl_Office> tbl_Office { get; set; }
        public virtual DbSet<tbl_Payment> tbl_Payment { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_ProductCategory> tbl_ProductCategory { get; set; }
        public virtual DbSet<tbl_ServiceUnit> tbl_ServiceUnit { get; set; }
        public virtual DbSet<tbl_Specialize> tbl_Specialize { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }
    }
}
