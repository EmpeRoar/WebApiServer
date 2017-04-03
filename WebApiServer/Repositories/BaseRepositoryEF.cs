using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using WebApiServer.DAL;
using WebApiServer.Models;

namespace WebApiServer.Repositories
{
    public class BaseRepositoryEF<T> : IBaseRepository<T> where T : class, IEntity, new()
    {
        private AppDBContext _context;
        public BaseRepositoryEF(AppDBContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void BulkSaveOrUpdate(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> FindAll()
        {
            IQueryable<T> q = _context.Set<T>();
            var list = await q.ToListAsync();
            return list.AsQueryable();
        }

        public async Task<IQueryable<T>> FindAll(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> q = _context.Set<T>();
            var list = q.Where(predicate);
            return list.AsQueryable();
        }

        public void Update(T entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Modified;
            addedEntity.Property("Created").IsModified = false;
            _context.SaveChanges();
        }
    }
}