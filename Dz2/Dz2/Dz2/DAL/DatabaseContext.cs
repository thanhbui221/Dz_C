using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dz2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Dz2.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext") { }

        public DbSet<Engine> Engines { get; set; }
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Tractor> Tractors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}