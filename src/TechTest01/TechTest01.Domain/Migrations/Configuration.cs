namespace TechTest01.Domain.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TechTest01.Domain.Catalog;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TechTestDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var products = new List<Product>
            {
                new Product { Name = "Polo T-Shirts",   Slug = "polo-t-shirts",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Price = 12, ImageUrl = "polo-t-shirts.jpg" },
                new Product { Name = "Girls Trousers",   Slug = "girls-trousers",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Price = 12, ImageUrl = "girls-trousers.jpg" },
                new Product { Name = "Jeans Pant",   Slug = "jeans-pant",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Price = 12, ImageUrl = "jeans-pant.jpg" },
            };
            products.ForEach(s => context.Products.AddOrUpdate(p => p.Slug, s));
            context.SaveChanges();
        }
    }
}
