using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void Create(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void Delete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> Read()
		{
            return _blogDal.Read();
		}

		public Blog? ReadById(int id)
		{
			return _blogDal.ReadById(id);
		}

		public List<Blog> ReadWithCategory()
		{
			return _blogDal.ReadWithCategory();
		}

		public void Update(Blog blog)
		{
			throw new NotImplementedException();
		}
	}
}
