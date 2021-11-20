using System;
using System.Collections.Generic;

namespace Autopark.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        T FindById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
