using Microsoft.EntityFrameworkCore;

namespace StandupIndicators.DB
{
    public class StandupDbContext : DbContext
    {
        public static string? DbPath { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@$"DataSource={DbPath}");
        }

        public DbSet<Model.Kpi> Kpis { get; set; }
        public DbSet<Model.KpiType> KpiTypes { get; set; }
        public DbSet<Model.Owner> Owners { get; set; }
        public DbSet<Model.Departament> Departaments { get; set; }
    }
}