using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IBlogService
    {
        void Create(Blog blog);
        List<Blog> Read();
        Blog? ReadById(int id);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> ReadWithCategory();
    }
}
