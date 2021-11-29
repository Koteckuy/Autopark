using Autopark.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Get();
        T FindById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
