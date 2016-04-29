namespace Trash.Domain.Entities
{
    public class DetailImage : BaseEntity
    {
        public string Url { get; set; }
        public int DetailId { get; set; }
        public virtual Detail Detail { get; set; }
    }
}
