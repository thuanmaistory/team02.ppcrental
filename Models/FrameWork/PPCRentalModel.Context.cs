﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.FrameWork
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DemoPPCRentalEntities : DbContext
    {
        public DemoPPCRentalEntities()
            : base("name=DemoPPCRentalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About_Us> About_Us { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<DISTRICT_Table> DISTRICT_Table { get; set; }
        public virtual DbSet<FEATURE> FEATUREs { get; set; }
        public virtual DbSet<PROJECT_STATUS> PROJECT_STATUS { get; set; }
        public virtual DbSet<PROPERTy> PROPERTies { get; set; }
        public virtual DbSet<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
        public virtual DbSet<PROPERTY_TYPE> PROPERTY_TYPE { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<STREET> STREETs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<WARD> WARDs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public object User { get; set; }
    }
}
