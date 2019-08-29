using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MyFirstWebAPIwithNetCore.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {

        }
        //burada dbsette verdiğim değişken ismi DB ye kaydedilen ismi olur.
        public DbSet<Product> products { get; set; }


    }
}
