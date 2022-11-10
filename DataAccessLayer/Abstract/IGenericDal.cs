using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Create(T entity);
        List<T> Read();
        T? ReadById(int id);
        void Update(T entity);
        void Delete(T entity);
        List<T> Filter(Expression<Func<T, bool>> filter);
    }
}
