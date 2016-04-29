namespace Trash.Domain.Entities
{
    using System.Collections.Generic;

    public class VehicleBrand : BaseEntity
    {
        public string Title { get; set; }
        public string LogoUrl { get; set; }
        public virtual List<VehicleModel> VehicleModels { get; set; }
    }
}
