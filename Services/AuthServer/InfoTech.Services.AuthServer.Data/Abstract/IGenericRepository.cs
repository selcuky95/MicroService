using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfoTech.Services.AuthServer.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Where(Expression<Func<TEntity,bool>> predicate) 
        Task AddAsync(TEntity entity);

        void Remove(TEntity entity);

        Task<TEntity> GetByIdAsync(int id);
    }
}