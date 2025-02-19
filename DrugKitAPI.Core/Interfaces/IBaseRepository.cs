﻿using System.Linq.Expressions;

namespace DrugKitAPI.Core.Interfaces
{
    public interface IBaseRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        T Update(T entity);
        Task DeleteAsync(T entity);

        Task<T> FindTWithIncludes<T>(int id, params Expression<Func<T, object>>[] includeProperties) where T : class;
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria);
        public Task<IEnumerable<T>> FindAllWithIncludes<T>(Expression<Func<T, bool>>? criteria, params Expression<Func<T, object>>[]? includeProperties) where T : class;
        public Task<T> FindTWithExpression<T>(params Expression<Func<T, bool>>[] expressions) where T : class;
        public Task DeleteAllAsync();
        public Task DeleteAllAsyncWithExpression(Expression<Func<T, bool>>? criteria = null);

    }
}
