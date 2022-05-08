using System;
using System.Linq.Expressions;

namespace ProjectManagement.Contracts
{
    public interface IRepositoryBase<T>
        where T : class
    {
        IQueryable<T> FindAll(bool trackChanges);

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
