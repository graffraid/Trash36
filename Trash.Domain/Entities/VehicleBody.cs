namespace Trash.Domain.Entities
{
    public class VehicleBody : BaseEntity
    {
        public string Title { get; set; }
        public int VehicleModelId { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
    }
}
