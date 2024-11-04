using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExoticIslands_api.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoticIslands_api.Data
{
    public class IslandContext : DbContext {
        public IslandContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Island>().ToTable("Islands");

            builder.Entity<Island>().HasData(SampleData.GetIslands());
        }

        public DbSet<Island> Islands { get; set; }
    }
}