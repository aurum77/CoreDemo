using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public string? Id { get; set; }
        public string? Username { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}
