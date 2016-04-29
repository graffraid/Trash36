namespace Trash.Domain.Entities
{
    using System.Collections.Generic;

    using Trash.Infrastructure.Enums;

    public class Detail : BaseEntity
    {
        public int? DetailTypeId { get; set; }
        public int? VehicleId { get; set; }
        public string PartNumber { get; set; }
        public string Colour { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public ComponentStatus Status { get; set; }
        public virtual DetailType DetailType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual List<DetailImage> DetailImages { get; set; }
    }
}
