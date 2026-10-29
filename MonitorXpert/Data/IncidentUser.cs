using Microsoft.EntityFrameworkCore;

namespace MonitorXpert.Data
{
    [PrimaryKey(nameof(IncidentId), nameof(UserId))]
    public class IncidentUser
    {
        public int IncidentId { get; set; }
        public int UserId { get; set; }

        public Incident Incident { get; set; }
        public User User { get; set; }
    }
}
