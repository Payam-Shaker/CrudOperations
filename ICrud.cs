using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudOperations
{
    public interface ICrud<T> where T : class
    {
            IEnumerable<T> GetAll();
            T GetById(object id);
            void Insert(T entity);
            void Update(T entity);
            void Delete(object id);
            void Save(T entity);
            IQueryable<T> Table { get; }
    }
}
