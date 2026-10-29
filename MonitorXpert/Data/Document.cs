namespace MonitorXpert.Data
{
    public class Document
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public string Name { get; set; }
        public string DocumentType { get; set; }
        public string? FileReference { get; set; }

        public Plant Plant { get; set; }
    }
}
