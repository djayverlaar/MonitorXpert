using System.Collections.Generic;

namespace MonitorXpert.Data
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PlantUser> PlantUsers { get; set; }
        public ICollection<Incident> Incidents { get; set; }
        public ICollection<MaintenanceTask> MaintenanceTasks { get; set; }
        public ICollection<Measurement> Measurements { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<CustomerReport> CustomerReports { get; set; }
    }
}
