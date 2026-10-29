using System;

namespace MonitorXpert.Data
{
    public class Measurement
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public DateTime MeasuredAt { get; set; }
        public decimal? EnergyProduction { get; set; }
        public decimal? Temperature { get; set; }
        public decimal? Efficiency { get; set; }
        public decimal? Profitability { get; set; }

        public Plant Plant { get; set; }
    }
}
