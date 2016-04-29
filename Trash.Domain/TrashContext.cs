namespace Trash.Domain
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Trash.Domain.Entities;

    public class TrashContext : DbContext
    {
        public TrashContext()
            : base("name=TrashConnectionString")
        {
        }

        public DbSet<Detail> Details { get; set; }
        public DbSet<DetailImage> DetailImages { get; set; }
        public DbSet<DetailType> DetailTypes { get; set; }
        public DbSet<DriveType> DriveTypes { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBody> VehicleBodies { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleImage> VehicleImages { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}