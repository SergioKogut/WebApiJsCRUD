using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiJsCRUD.Models.Configuration;

namespace WebApiJsCRUD.Models
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            //  Database.Migrate();
            
        }
        public ProductContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //  optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.ApplyConfiguration(new ProductConfiguration());

        }
    }
}
