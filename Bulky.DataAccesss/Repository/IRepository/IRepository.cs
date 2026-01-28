using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccesss.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
