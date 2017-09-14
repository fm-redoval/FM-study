using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStudy.Models
{
    public class ProductContext
    {
        public ProductContext()
           : base("WingtipToys")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}