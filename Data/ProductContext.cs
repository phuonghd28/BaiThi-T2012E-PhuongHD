using BaiThiT2012E.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiThiT2012E.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext") { }
        public DbSet<Product> Products  { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}