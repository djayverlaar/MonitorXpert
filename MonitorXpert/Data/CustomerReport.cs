using System;

namespace MonitorXpert.Data
{
    public class CustomerReport
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PlantId { get; set; }
        public int? IncidentId { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string IncidentType { get; set; }
        public string? Description { get; set; }
        public string Source { get; set; }
        public bool? AutomaticUpdates { get; set; }
        public DateTime ReportedAt { get; set; }

        public Customer Customer { get; set; }
        public Plant Plant { get; set; }
        public Incident? Incident { get; set; }
    }
}
