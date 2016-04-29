namespace Trash.Domain.Entities
{
    using System;

    public class Stuff : BaseEntity
    {
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public double? Price { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public double? PurchasePrice { get; set; }
    }
}
