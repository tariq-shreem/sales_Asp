using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Products> products { get; set; }

        public DbSet<Sales> sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                 "Data Source=.;Initial Catalog=Task1;Integrated Security=True;TrustServerCertificate=True"
                 );

        }
    }
}
