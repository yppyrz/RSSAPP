using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSSAPP.Models
{
    public class RssAppDbContext:DbContext
    {
        public RssAppDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RssAppDb;uid=sa;pwd=1234;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Source> Sources { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // entity configürasyon işlemleri yapıyoruz.
            base.OnModelCreating(modelBuilder);
        }
    }
}
