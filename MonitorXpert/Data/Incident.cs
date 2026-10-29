using System;
using System.Collections.Generic;

namespace MonitorXpert.Data
{
    public class Incident
    {
        public int Id { get; set; }
        public string IncidentNumber { get; set; }
        public int PlantId { get; set; }
        public string Location { get; set; }
        public string IncidentType { get; set; }
        public string? Comments { get; set; }
        public string Status { get; set; }
        public string? Urgency { get; set; }
        public string? Priority { get; set; }
        public string Source { get; set; }
        public DateTime ReportedAt { get; set; }
        public DateTime? ExpectedRecoveryAt { get; set; }
        public DateTime? ResolvedAt { get; set; }

        public Plant Plant { get; set; }
        public ICollection<IncidentUser> IncidentUsers { get; set; }
        public ICollection<IncidentProgress> ProgressEntries { get; set; }
        public ICollection<CustomerReport> CustomerReports { get; set; }
    }
}
