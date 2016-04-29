namespace Trash.Domain.Entities
{
    using System.Collections.Generic;

    public class DriveType : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }
    }
}
