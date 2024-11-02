﻿using Sitem.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.DAL.GenericRepository.EfCore.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        public int Create(T entity);
        public int Update(T entity);
        public int Delete(T entity);
        public T? GetById(int id);
        public T? Get(Expression<Func<T, bool>> predicate);
        public List<T>? GetAll(Expression<Func<T, bool>> predicate=null);

        public IQueryable<T>? GetAllInclude(Expression<Func<T,bool>> prdicate=null, params Expression<Func<T, object>>[] include);
    }
}
