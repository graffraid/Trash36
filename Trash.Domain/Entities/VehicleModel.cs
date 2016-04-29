namespace Trash.Domain.Entities
{
    using System.Collections.Generic;

    public class VehicleModel : BaseEntity
    {
        public string Title { get; set; }
        public int VehicleBrandId { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public virtual List<VehicleBody> VehicleBodies { get; set; }
    }
}
