using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudOperations
{
    public class Crud<T> : ICrud<T> where T : class
    {
        private DbContext _dbContext = null;
        private DbSet<T> table = null;
        public Crud(DbContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public IQueryable<T> Table { get; }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            Save(existing);
        }
        public void Insert(T entity)
        {
            table.Add(entity);
            Save(entity);
        }
        public void Update(T entity)
        {
            table.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            Save(entity);
        }

        public void Save(T entity)
        {
            _dbContext.SaveChanges();
        }
    }
}
