using System;
using System.Collections.Generic;
using System.Text;

namespace B2B.Data
{
    public class AbstractRepository<T> : IRepository<T> where T : class
    {
        public T Get(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

      
    }
}
