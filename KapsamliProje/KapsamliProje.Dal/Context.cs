using KapsamliProje.Ent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Dal
{
    public class Context:DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FatDetail>()
                .HasKey(f => new { f.Id, f.ProductId });
        }
        public Context(DbContextOptions<Context> op ):base(op)
        {

        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products{ get; set; }
        public DbSet<Counties> Counties{ get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Suppliers> Suppliers{ get; set; }
        public DbSet<Employees> Employees{ get; set; }
        public DbSet<EndConsumers> EndConsumers { get; set; }
        public DbSet<Users>  Users { get; set; }
        public DbSet<FatMaster> FatMaster{ get; set; }
        public DbSet<FatDetail> FatDetail { get; set; }

    }
}
