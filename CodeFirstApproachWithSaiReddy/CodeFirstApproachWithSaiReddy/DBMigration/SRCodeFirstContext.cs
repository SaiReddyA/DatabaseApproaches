using CodeFirstApproachWithSaiReddy.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachWithSaiReddy.DBMigration
{
    public class SRCodeFirstContext : DbContext
    {
        public SRCodeFirstContext(DbContextOptions<SRCodeFirstContext> options)
             : base(options) { }


        public DbSet<Category> categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
