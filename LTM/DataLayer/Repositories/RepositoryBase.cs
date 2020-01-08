using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public abstract class RepositoryBase<T> where T : class
    {
        private readonly LtmDataContext _dataContext;
        private readonly DbSet<T> _dbset;

        protected RepositoryBase(IDbFactory dbFactory)
        {
            _dataContext = dbFactory.Get();
            _dbset = _dataContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbset.Attach(entity);
            _dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }
    }
}