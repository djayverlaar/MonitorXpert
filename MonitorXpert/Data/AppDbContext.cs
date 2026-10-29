using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MonitorXpert.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Plant> plants { get; set; }
        public DbSet<PlantUser> plants_users { get; set; }
        public DbSet<IncidentUser> incidents_users { get; set; }
        public DbSet<Incident> incidents { get; set; }
        public DbSet<IncidentProgress> incident_progress { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<CustomerReport> customer_reports { get; set; }
        public DbSet<MaintenanceTask> maintenance_tasks { get; set; }
        public DbSet<Measurement> measurements { get; set; }
        public DbSet<Document> documents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                ConfigurationManager.ConnectionStrings["MonitorXpert"].ConnectionString,
                ServerVersion.Parse("8.0.30")
            );
        }
    }
}
