using System;

namespace MonitorXpert.Data
{
    public class MaintenanceTask
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public string Task { get; set; }
        public DateTime? ScheduledFrom { get; set; }
        public DateTime? ScheduledUntil { get; set; }
        public string Status { get; set; }

        public Plant Plant { get; set; }
    }
}
