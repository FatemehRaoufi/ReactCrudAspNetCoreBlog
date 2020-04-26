using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ReactCrudAspNetCoreBlog.Models.Data
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options)
        {

        }
     
        public DbSet<BlogDTO> Blogs { get; set; }
        public DbSet<CategoryDTO> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogDTO>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Blogs)
               .HasForeignKey(p => p.CategoryForeignKey);
        }

    }
}
