﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orsimu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdatbazisEntities : DbContext
    {
        public AdatbazisEntities()
            : base("name=AdatbazisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fegyver> Fegyver { get; set; }
        public virtual DbSet<Felhaszn> Felhaszn { get; set; }
        public virtual DbSet<i_fegyver> i_fegyver { get; set; }
        public virtual DbSet<invertory> invertory { get; set; }
        public virtual DbSet<Karakter> Karakter { get; set; }
        public virtual DbSet<Leny> Leny { get; set; }
    }
}
