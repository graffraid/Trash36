namespace Trash.Domain.Initializer
{
    public static partial class Initializer
    {
        public static void Seed(TrashContext ctx)
        {
            InitializeTy(ctx);
            InitializeParam(ctx);
            
            ctx.SaveChanges();
        }

        static partial void InitializeTy(TrashContext ctx);

        static partial void InitializeParam(TrashContext ctx);
    }
}
