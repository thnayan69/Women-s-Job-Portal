﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADMS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WOEntities : DbContext
    {
        public WOEntities()
            : base("name=WOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<E_USERS> E_USERS { get; set; }
        public DbSet<JOB_CIRCULARS> JOB_CIRCULARS { get; set; }
        public DbSet<JS_USERS> JS_USERS { get; set; }
        public DbSet<PM_USERS> PM_USERS { get; set; }
        public DbSet<EMP> EMPs { get; set; }
        public DbSet<JOB_SEEKERS> JOB_SEEKERS { get; set; }
        public DbSet<PORTAL_MODERATORS> PORTAL_MODERATORS { get; set; }
        public DbSet<VERIFY_HISTORY> VERIFY_HISTORY { get; set; }
    }
}
