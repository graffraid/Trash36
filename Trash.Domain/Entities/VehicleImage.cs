namespace Trash.Domain.Entities
{
    public class VehicleImage : BaseEntity
    {
        public string Url { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
