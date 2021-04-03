using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountingMaterials.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Materials> Materials { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ManufacturingCost> ManufacturingCosts { get; set; }
        public DbSet<DebtAct> DebtActs { get; set; }
        public DbSet<RequiementAct> RequiementActs { get; set; }
        public DbSet<Timecards> Timecards { get; set; }
        public DbSet<Waybill> Waybills { get; set; }
        public DbSet<UseInProduction> UseInProductions { get; set; }
        public DbSet<UseOfMatrials> UseOfMatrials { get; set; }
        public DbSet<RequirementInvoice> RequirementInvoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Materials>(e => e.HasIndex(p => p.Name));
            modelBuilder.Entity<Employee>(e => e.HasIndex(p => p.Name));
            modelBuilder.Entity<Unit>(e => e.HasIndex(p => p.Name));
            modelBuilder.Entity<ManufacturingCost>(e => e.HasIndex(p => p.Name));
        }
    }
}
