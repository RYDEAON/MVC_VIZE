﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace görselvizesi3.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_mudurEntities : DbContext
    {
        public db_mudurEntities()
            : base("name=db_mudurEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_idare> tbl_idare { get; set; }
        public virtual DbSet<tbl_ogrenci> tbl_ogrenci { get; set; }
        public virtual DbSet<tbl_ogretmenler> tbl_ogretmenler { get; set; }
        public virtual DbSet<tbl_personel> tbl_personel { get; set; }
        public virtual DbSet<tbl_rapor> tbl_rapor { get; set; }
        public virtual DbSet<tbl_rapor1> tbl_rapor1 { get; set; }
    }
}
