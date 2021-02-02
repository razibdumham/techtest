namespace TechTest01.Domain.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TechTest01.Domain.Catalog;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTest01.Domain.TechTestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechTest01.Domain.TechTestDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var products = new List<Product>
            {
                new Product { Name = "Polo T-Shirts",   Slug = "polo-t-shirts",
                    Description = "", Price = 12, ImageUrl = "" },
                new Product { Name = "Girls Trousers",   Slug = "girls-trousers",
                    Description = "", Price = 12, ImageUrl = "" },
                new Product { Name = "Jeans Pant",   Slug = "jeans-pant",
                    Description = "", Price = 12, ImageUrl = "" },
            };
            products.ForEach(s => context.Products.AddOrUpdate(p => p.Slug, s));
            context.SaveChanges();
        }
    }
}
