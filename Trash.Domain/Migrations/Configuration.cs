namespace Trash.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Trash.Domain.TrashContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Trash.Domain.TrashContext context)
        {
            if (!context.Vehicles.Any())
            {
                Initializer.Initializer.Seed(context);
            }
        }
    }
}
