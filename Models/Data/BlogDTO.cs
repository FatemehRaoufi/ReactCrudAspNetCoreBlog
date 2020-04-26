using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCrudAspNetCoreBlog.Models.Data
{
    [Table("tblBlog")]
    public class BlogDTO
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Body { get; set; }    
        public bool Active { get; set; }

        public CategoryDTO Category { get; set; }
        public int CategoryForeignKey { get; set; }    
    }
}
