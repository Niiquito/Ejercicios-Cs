﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDWINFORMS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class editoEntities : DbContext
    {
        public editoEntities()
            : base("name=editoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<titulo> titulo { get; set; }
    }
}
