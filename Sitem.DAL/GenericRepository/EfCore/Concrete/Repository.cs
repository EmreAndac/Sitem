using Microsoft.EntityFrameworkCore;
using Sitem.DAL.GenericRepository.EfCore.Abstract;
using Sitem.Entities.DbContexts;
using Sitem.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.DAL.GenericRepository.EfCore.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        readonly SqlDbContext sqlDbContext;
        public Repository()
        {
            sqlDbContext = new SqlDbContext();
        }
        #region CRUD Islemleri
        public int Create(T entity)
        {
            sqlDbContext.Set<T>().Add(entity);
            return sqlDbContext.SaveChanges();
        }
        public int Update(T entity)
        {
            sqlDbContext.Set<T>().Update(entity);
            return sqlDbContext.SaveChanges();
        }
        public int Delete(T entity)
        {
            sqlDbContext.Set<T>().Remove(entity);
            return sqlDbContext.SaveChanges();
        }
        #endregion

        #region Select Metodları
        public List<T>? GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if(predicate != null)
            {
                return sqlDbContext.Set<T>().Where(predicate).ToList();
            }
            return sqlDbContext.Set<T>().ToList();
        }

        public IQueryable<T>? GetAllInclude(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query = sqlDbContext.Set<T>();
            if(predicate != null)
            {
                query = sqlDbContext.Set<T>().Where(predicate);
            }
            return include.Aggregate(query, (current, includeProperty)=>current.Include(includeProperty));
        }

        public T? GetById(int id)
        {
            return sqlDbContext.Set<T>().Find(id);  
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return sqlDbContext.Set<T>().FirstOrDefault(predicate);
        }
        #endregion

    }
}
