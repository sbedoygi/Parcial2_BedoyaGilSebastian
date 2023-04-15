using Microsoft.EntityFrameworkCore;
using Parcial2_BedoyaGilSebastian.DAL.Entities;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Parcial2_BedoyaGilSebastian.DAL
{
    public class DataBaseContextcs :DbContext
    {
        public DataBaseContextcs(DbContextOptions<DataBaseContextcs>options) :base (options)
        {
        }

        public DbSet<Tickets> Ticketes{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tickets>().HasIndex(c => c.UseDate).IsUnique();
        }

    }
}
