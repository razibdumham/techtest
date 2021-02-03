using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Domain.Migrations;

namespace TechTest01.Domain
{
    public class TechTestDbContext : DbContext
    {
        public TechTestDbContext() : base("TechTestDB")
        {
        }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            

        }
    }
}
