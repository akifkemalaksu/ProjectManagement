using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using ProjectManagement.Contracts.Repository.Repositories;
using ProjectManagement.Repository;

namespace ProjectManagement.Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        protected readonly RepositoryContext _repositoryContext;
        protected readonly DbSet<T> _dbSet;

        protected RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _dbSet = _repositoryContext.Set<T>();
        }

        public void Create(T entity) => _dbSet.Add(entity);

        public void Delete(T entity) => _dbSet.Remove(entity);

        public void Update(T entity) => _dbSet.Update(entity);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            _dbSet.AsNoTracking() :
            _dbSet;

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            _dbSet.Where(expression).AsNoTracking() :
            _dbSet.Where(expression);
    }
}
