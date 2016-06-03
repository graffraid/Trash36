namespace Trash.Domain.Initializer
{
    using System.Collections.Generic;
    using Entities;

    public static partial class Initializer
    {
        static partial void InitializeTy(TrashContext ctx)
        {
            var toyota_Avalon_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "MCX10"}
                                    };
            var toyota_Camry_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "CV30"},
                                        new VehicleBody { Title = "CV35"},
                                        new VehicleBody { Title = "SV35"},
                                        new VehicleBody { Title = "VCV10"}
                                    };
            var toyota_CarinaE_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "AT190"},
                                        new VehicleBody { Title = "AT191"}
                                    };
            var toyota_CarinaFF_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "CT176"}
                                    };
            var toyota_CarinaII_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "170"}
                                    };
            var toyota_Celica_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "ZZT230"}
                                    };
            var toyota_Chaser_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "LX80"}
                                    };
            var toyota_Corolla_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "AE100"},
                                        new VehicleBody { Title = "AE101"},
                                        new VehicleBody { Title = "AE110"},
                                        new VehicleBody { Title = "AE90"},
                                        new VehicleBody { Title = "AE91"},
                                        new VehicleBody { Title = "AE92"},
                                        new VehicleBody { Title = "CE100"},
                                        new VehicleBody { Title = "CT195"},
                                        new VehicleBody { Title = "EE102"}
                                    };
            var toyota_CorollaCeres_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "AE101"}
                                    };
            var toyota_Corona_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "CT195"}
                                    };
            var toyota_Crown_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "LS131"}
                                    };
            var toyota_Duet_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "M100"}
                                    };
            var toyota_HiluxSurf_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "LN61"}
                                    };
            var toyota_MarkII_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "JZX90"},
                                        new VehicleBody { Title = "GX110"}
                                    };
            var toyota_Passo_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "KGC10"}
                                    };
            var toyota_Platz_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "SCP10"}
                                    };
            var toyota_Rav4_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "CXA10"},
                                        new VehicleBody { Title = "ACA20"}
                                    };
            var toyota_Sprinter_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "AE110"},
                                        new VehicleBody { Title = "AE91"},
                                        new VehicleBody { Title = "EE101"}
                                    };
            var toyota_Starlet_VehicleBodies = new List<VehicleBody>
                                    {
                                        new VehicleBody { Title = "EP82"}
                                    };

            var toyotaVehicleModels = new List<VehicleModel>
                                          {
                                              new VehicleModel { Title = "Avalon", VehicleBodies = toyota_Avalon_VehicleBodies },
                                              new VehicleModel { Title = "Camry", VehicleBodies = toyota_Camry_VehicleBodies },
                                              new VehicleModel { Title = "Carina E", VehicleBodies = toyota_CarinaE_VehicleBodies },
                                              new VehicleModel { Title = "Carina FF", VehicleBodies = toyota_CarinaFF_VehicleBodies },
                                              new VehicleModel { Title = "Carina II", VehicleBodies = toyota_CarinaII_VehicleBodies },
                                              new VehicleModel { Title = "Celica", VehicleBodies = toyota_Celica_VehicleBodies },
                                              new VehicleModel { Title = "Chaser", VehicleBodies = toyota_Chaser_VehicleBodies },
                                              new VehicleModel { Title = "Corolla", VehicleBodies = toyota_Corolla_VehicleBodies },
                                              new VehicleModel { Title = "Corolla Ceres", VehicleBodies =  toyota_CorollaCeres_VehicleBodies},
                                              new VehicleModel { Title = "Corona", VehicleBodies = toyota_Corona_VehicleBodies },
                                              new VehicleModel { Title = "Crown", VehicleBodies = toyota_Crown_VehicleBodies },
                                              new VehicleModel { Title = "Duet", VehicleBodies = toyota_Duet_VehicleBodies },
                                              new VehicleModel { Title = "Hilux Surf", VehicleBodies = toyota_HiluxSurf_VehicleBodies },
                                              new VehicleModel { Title = "Mark II", VehicleBodies = toyota_MarkII_VehicleBodies },
                                              new VehicleModel { Title = "Passo", VehicleBodies = toyota_Passo_VehicleBodies },
                                              new VehicleModel { Title = "Platz", VehicleBodies = toyota_Platz_VehicleBodies },
                                              new VehicleModel { Title = "RAV4", VehicleBodies = toyota_Rav4_VehicleBodies },
                                              new VehicleModel { Title = "Sprinter", VehicleBodies = toyota_Sprinter_VehicleBodies},
                                              new VehicleModel { Title = "Starlet", VehicleBodies = toyota_Starlet_VehicleBodies}
                                          };
            var toyotaVehicleBrand = new VehicleBrand
            {
                Title = "Toyota",
                VehicleModels = toyotaVehicleModels
            };

            ctx.VehicleBrands.Add(toyotaVehicleBrand);
        }
    }
}
