﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrSzimulator2000
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
    
        public virtual DbSet<Felhasznalok> Felhasznalok { get; set; }
        public virtual DbSet<Karakterek> Karakterek { get; set; }
        public virtual DbSet<Lakhely> Lakhely { get; set; }
        public virtual DbSet<Szornyek> Szornyek { get; set; }
    }
}
