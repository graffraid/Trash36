namespace Trash.Domain.Entities
{
    using System.Collections.Generic;

    public class DetailType : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<Detail> Details { get; set; }
    }
}
