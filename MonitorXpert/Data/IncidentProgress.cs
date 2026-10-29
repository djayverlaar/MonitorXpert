using System;

namespace MonitorXpert.Data
{
    public class IncidentProgress
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public int? UserId { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public string? OnHoldReason { get; set; }
        public DateTime CreatedAt { get; set; }

        public Incident Incident { get; set; }
        public User? User { get; set; }
    }
}
