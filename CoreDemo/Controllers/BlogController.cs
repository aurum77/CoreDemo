using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        readonly BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.ReadWithCategory();
            return View(values);
        }

        public IActionResult Content(int id)
        {
            var values = bm.ReadById(id);
            return View(values);
        }
    }
}
