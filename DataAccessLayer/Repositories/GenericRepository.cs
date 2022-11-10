using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Create(T entity)
        {
            using var c = new CoreDemoContext();
            c.Add(entity);
            c.SaveChanges();
        }

        public List<T> Read()
        {
            using var c = new CoreDemoContext();
            return c.Set<T>().ToList();
        }

        public T? ReadById(int id)
        {
            using var c = new CoreDemoContext();
            return c.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using var c = new CoreDemoContext();
            c.SaveChanges();
        }
        public void Delete(T entity)
        {
            using var c = new CoreDemoContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> Filter(Expression<Func<T, bool>> filter)
        {
            using var c = new CoreDemoContext();
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
