﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shoe_Project_V2.Model.Model_Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Shoe_DbEntities : DbContext
    {
        public Shoe_DbEntities()
            : base("name=Shoe_DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Renk> Renk { get; set; }
        public virtual DbSet<Satis_Detay> Satis_Detay { get; set; }
        public virtual DbSet<Satislar> Satislar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Urun_Detay> Urun_Detay { get; set; }
        public virtual DbSet<Numara> Numara { get; set; }
    }
}
