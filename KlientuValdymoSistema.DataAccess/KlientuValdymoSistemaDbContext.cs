using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using KlientuValdymoSistema.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KlientuValdymoSistema.DataAccess
{
    public class KlientuValdymoSistemaDbContext : DbContext
    {
        public KlientuValdymoSistemaDbContext():base("KlientuValdymoSistemaDb")
        {

        }
        public DbSet<Klientas> Klientai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
