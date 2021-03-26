using CRUD.App.Data.Entities;

using Microsoft.EntityFrameworkCore;

namespace CRUD.App.Data.Communication
{
    public class MaintenanceContext : DbContext
    {
        public MaintenanceContext()
        {
        }
        public MaintenanceContext(DbContextOptions<MaintenanceContext> options) : base(options)
        {
        }
        public DbSet<ProductBE> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBE>();
        }
    }
}
