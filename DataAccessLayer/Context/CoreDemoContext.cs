using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class CoreDemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-O277L04;Initial Catalog=CoreDemoDb;Integrated Security=True");

        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Author>? Authors { get; set; }
    }
}
