﻿using Contracts;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected eWaiterTestContext _context { get; set; }
        public RepositoryBase(eWaiterTestContext context)
        {
            this._context = context;
        }
        public void Create(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return this._context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this._context.Set<T>().Update(entity);
        }
    }
}
