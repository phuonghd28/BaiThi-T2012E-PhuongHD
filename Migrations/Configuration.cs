namespace BaiThiT2012E.Migrations
{
    using BaiThiT2012E.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaiThiT2012E.Data.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BaiThiT2012E.Data.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var categories = new List<Category>
            {
            new Category{CategoryName="Áo thun", Description="áo thun"},
            new Category{CategoryName="Áo khoác", Description="áo khoác"},
            new Category{CategoryName="Quần", Description="quần"},
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();


            var products = new List<Product>
            {
            new Product{ProductName="Áo thun", QuantityPerUnit=100, CategoryId=1, UnitPrice=50000},
            new Product{ProductName="Áo ngắn tay cổ lọ", QuantityPerUnit=200, CategoryId=1, UnitPrice=100000},
            new Product{ProductName="Áo dài tay", QuantityPerUnit=300, CategoryId=1, UnitPrice=50000},
            new Product{ProductName="Áo gió", QuantityPerUnit=400, CategoryId=2, UnitPrice=500000},
            new Product{ProductName="Áo thu đông", QuantityPerUnit=500, CategoryId=2, UnitPrice=250000},
            new Product{ProductName="Áo bomber", QuantityPerUnit=100, CategoryId=2, UnitPrice=1000000},
            new Product{ProductName="Quần bò", QuantityPerUnit=200, CategoryId=3, UnitPrice=250000},
            new Product{ProductName="Quần kaki", QuantityPerUnit=300, CategoryId=3, UnitPrice=300000},
            new Product{ProductName="Quần jogger", QuantityPerUnit=400, CategoryId=3, UnitPrice=500000},
    
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
