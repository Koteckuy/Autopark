using Autopark.Models;
using Autopark.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Autopark.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly AutoparkContext context;

        public Repository(AutoparkContext _context)
        {
            context = _context;
        }

        public IQueryable<T> Get()
        {
            return context.Set<T>();
        }

        public T FindById(int id)
        {
            return Get().FirstOrDefault(x => x.ID == id);
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(FindById(entity.ID)).CurrentValues.SetValues(entity);
            context.Entry(FindById(entity.ID)).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            T dbEntity = FindById(entity.ID);
            if (dbEntity != null)
            {
                entity.Deleted = true;
                context.Entry(FindById(entity.ID)).CurrentValues.SetValues(entity);
                context.Entry(FindById(entity.ID)).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
