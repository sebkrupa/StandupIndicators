using Microsoft.EntityFrameworkCore;

namespace StandupIndicators.DB
{
    public class StandupDbContext : DbContext
    {
        public static string? DbPath { get; set; } //= "C:\\Users\\sebkr\\source\\repos\\StandupIndicators\\DB\\StandupDatabase.db";
        public StandupDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@$"DataSource={DbPath}");
        }

        public virtual DbSet<Model.Kpi> Kpis { get; set; }
        public virtual DbSet<Model.KpiType> KpiTypes { get; set; }
        public virtual DbSet<Model.Owner> Owners { get; set; }
        public virtual DbSet<Model.Departament> Departaments { get; set; }
    }
}