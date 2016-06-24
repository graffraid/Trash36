namespace Trash.Repository.Interface
{
    using System.Collections.Generic;
    using Trash.Domain.Entities;

    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
    }
}
