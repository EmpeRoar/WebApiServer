using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApiServer.Models;

namespace WebApiServer.Repositories
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        Task<IQueryable<T>> FindAll();
        Task<IQueryable<T>> FindAll(Expression<Func<T, bool>> predicate);
        Task<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        void BulkSaveOrUpdate(List<T> entities);
    }
}
