using System;

namespace MonitorXpert.Data
{
    public class Contract
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ContractNumber { get; set; }
        public string Status { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? Agreements { get; set; }

        public Customer Customer { get; set; }
    }
}
