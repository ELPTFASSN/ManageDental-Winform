﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageSoftware.ModelManage
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelEntities : DbContext
    {
        public ModelEntities()
            : base("name=ModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_config_practice> tb_config_practice { get; set; }
        public virtual DbSet<tb_exercise> tb_exercise { get; set; }
        public virtual DbSet<tb_person> tb_person { get; set; }
        public virtual DbSet<tb_person_exercise> tb_person_exercise { get; set; }
    }
}
