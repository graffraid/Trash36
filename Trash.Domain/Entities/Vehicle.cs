namespace Trash.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    public class Vehicle : BaseEntity
    {
        public int? VehicleBrandId { get; set;}
        public int? VehicleModelId { get; set; }
        public int? VehicleBodyId { get; set; }
        public int? Year { get; set; }
        public string Vin { get; set; }
        public int? Mileage { get; set; }
        public bool? LeftHandDrive { get; set; }
        public int DriveTypeId { get; set; }
        public int TransmissionTypeId { get; set; }
        public string Engine { get; set; }
        public string Description { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public double? PurchasePrice { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public virtual VehicleBody VehicleBody { get; set; }
        public virtual DriveType DriveType { get; set; }
        public virtual TransmissionType TransmissionType { get; set; }
        public virtual List<Detail> Details { get; set; }
    }
}
