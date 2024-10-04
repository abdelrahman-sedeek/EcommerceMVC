using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Contexts
{
   
    public class ProgramContext:DbContext
    {
        public DbSet<Category> categories { get; set; }
        public ProgramContext(DbContextOptions<ProgramContext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id=1,Name="Action", DisplayOrder=1},
            //    new Category { Id=2,Name="SiFi", DisplayOrder=2},
            //    new Category { Id=3,Name="history", DisplayOrder=5}
            //    );
        }

    }
}
