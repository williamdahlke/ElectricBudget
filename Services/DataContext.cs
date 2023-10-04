using ElectricBudget.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Windows;

namespace ElectricBudget.Services
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<MaterialRepository> Material { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =" + System.Environment.CurrentDirectory + @"\dados.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MaterialRepository>().HasKey(t => t.Id);
        }

    }
}
