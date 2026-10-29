using System.Collections.Generic;

namespace MonitorXpert.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string? Email { get; set; }
        public string Role { get; set; }

        public ICollection<PlantUser> PlantUsers { get; set; }
        public ICollection<IncidentUser> IncidentUsers { get; set; }
        public ICollection<IncidentProgress> IncidentProgressEntries { get; set; }
    }
}
