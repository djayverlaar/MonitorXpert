using Microsoft.EntityFrameworkCore;

namespace MonitorXpert.Data
{
    [PrimaryKey(nameof(PlantId), nameof(UserId))]
    public class PlantUser
    {
        public int PlantId { get; set; }
        public int UserId { get; set; }

        public Plant Plant { get; set; }
        public User User { get; set; }
    }
}
