namespace Trash.Repository.Repository
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Trash.Domain;
    using Trash.Domain.Entities;
    using Trash.Repository.Interface;

    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private DbContext ctx;
        private IDbSet<T> entity;

        public GenericRepository()
        {
            this.ctx = new TrashContext();
            entity = ctx.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }
    }
}
