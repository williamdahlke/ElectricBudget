using ElectricBudget.Models.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Services
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Data Source=dados.db")
        {

        }

        public DbSet<MaterialRepository> Material { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataContext>(null);
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<Cerca>().HasKey(b => b.id);

        }
    }
}
