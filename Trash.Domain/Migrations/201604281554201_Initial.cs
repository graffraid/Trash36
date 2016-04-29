namespace Trash.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        DetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Details", t => t.DetailId, cascadeDelete: true)
                .Index(t => t.DetailId);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DetailTypeId = c.Int(),
                        VehicleId = c.Int(),
                        PartNumber = c.String(),
                        Colour = c.String(),
                        Description = c.String(),
                        Price = c.Double(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetailTypes", t => t.DetailTypeId)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId)
                .Index(t => t.DetailTypeId)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.DetailTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleBrandId = c.Int(),
                        VehicleModelId = c.Int(),
                        VehicleBodyId = c.Int(),
                        Year = c.Int(),
                        Vin = c.String(),
                        Mileage = c.Int(),
                        LeftHandDrive = c.Boolean(),
                        DriveTypeId = c.Int(nullable: false),
                        TransmissionTypeId = c.Int(nullable: false),
                        Engine = c.String(),
                        Description = c.String(),
                        PurchaseDate = c.DateTime(),
                        PurchasePrice = c.Double(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DriveTypes", t => t.DriveTypeId, cascadeDelete: true)
                .ForeignKey("dbo.TransmissionTypes", t => t.TransmissionTypeId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleBodies", t => t.VehicleBodyId)
                .ForeignKey("dbo.VehicleBrands", t => t.VehicleBrandId)
                .ForeignKey("dbo.VehicleModels", t => t.VehicleModelId)
                .Index(t => t.VehicleBrandId)
                .Index(t => t.VehicleModelId)
                .Index(t => t.VehicleBodyId)
                .Index(t => t.DriveTypeId)
                .Index(t => t.TransmissionTypeId);
            
            CreateTable(
                "dbo.DriveTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransmissionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleBodies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        VehicleModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VehicleModels", t => t.VehicleModelId, cascadeDelete: false)
                .Index(t => t.VehicleModelId);
            
            CreateTable(
                "dbo.VehicleModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        VehicleBrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VehicleBrands", t => t.VehicleBrandId, cascadeDelete: false)
                .Index(t => t.VehicleBrandId);
            
            CreateTable(
                "dbo.VehicleBrands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        LogoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stuffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PartNumber = c.String(),
                        Price = c.Double(),
                        PurchaseDate = c.DateTime(),
                        PurchasePrice = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        VehicleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleImages", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "VehicleModelId", "dbo.VehicleModels");
            DropForeignKey("dbo.Vehicles", "VehicleBrandId", "dbo.VehicleBrands");
            DropForeignKey("dbo.Vehicles", "VehicleBodyId", "dbo.VehicleBodies");
            DropForeignKey("dbo.VehicleModels", "VehicleBrandId", "dbo.VehicleBrands");
            DropForeignKey("dbo.VehicleBodies", "VehicleModelId", "dbo.VehicleModels");
            DropForeignKey("dbo.Vehicles", "TransmissionTypeId", "dbo.TransmissionTypes");
            DropForeignKey("dbo.Vehicles", "DriveTypeId", "dbo.DriveTypes");
            DropForeignKey("dbo.Details", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Details", "DetailTypeId", "dbo.DetailTypes");
            DropForeignKey("dbo.DetailImages", "DetailId", "dbo.Details");
            DropIndex("dbo.VehicleImages", new[] { "VehicleId" });
            DropIndex("dbo.VehicleModels", new[] { "VehicleBrandId" });
            DropIndex("dbo.VehicleBodies", new[] { "VehicleModelId" });
            DropIndex("dbo.Vehicles", new[] { "TransmissionTypeId" });
            DropIndex("dbo.Vehicles", new[] { "DriveTypeId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleBodyId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleModelId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleBrandId" });
            DropIndex("dbo.Details", new[] { "VehicleId" });
            DropIndex("dbo.Details", new[] { "DetailTypeId" });
            DropIndex("dbo.DetailImages", new[] { "DetailId" });
            DropTable("dbo.VehicleImages");
            DropTable("dbo.Stuffs");
            DropTable("dbo.VehicleBrands");
            DropTable("dbo.VehicleModels");
            DropTable("dbo.VehicleBodies");
            DropTable("dbo.TransmissionTypes");
            DropTable("dbo.DriveTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.DetailTypes");
            DropTable("dbo.Details");
            DropTable("dbo.DetailImages");
        }
    }
}
