using Microsoft.EntityFrameworkCore;
using Sitem.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.Entities.DbContexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Awards> Awards { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Skills> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=. ;Database=SitemDb; Trusted_Connection=true; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }
}
