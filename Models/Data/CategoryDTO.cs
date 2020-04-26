using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCrudAspNetCoreBlog.Models.Data
{
    [Table("tblCategories")]  
    public class CategoryDTO
    {

        public ICollection<BlogDTO> Blogs { get; set; }
      
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
     
    }
}
}
