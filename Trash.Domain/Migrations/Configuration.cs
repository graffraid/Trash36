namespace Trash.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    
    internal sealed class Configuration : DbMigrationsConfiguration<Trash.Domain.TrashContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Trash.Domain.TrashContext context)
        {
            Initializer.Seed(context);
        }
    }
}
