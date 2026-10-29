using System.Collections.Generic;

namespace MonitorXpert.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<CustomerReport> CustomerReports { get; set; }
    }
}
