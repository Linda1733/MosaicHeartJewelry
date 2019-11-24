using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MosaicHeartJewelry.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.AddRange(
                    new Product
                    {
                        Name = "Heart Necklace",
                        Description = "Heart Necklace",
                        Category = "Necklace",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Dragonfly Necklace",
                        Description = "Dragonfly Necklace",
                        Category = "Necklace",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Jade Teardrop Necklace",
                        Description = "Pendant Necklace",
                        Category = "Necklace",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Emerald Drop Earrings",
                        Description = "Emerald Earrings",
                        Category = "Earrings",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Citrine Drop Earrings",
                        Description = "Citrine Earrings",
                        Category = "Earrings",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Sapphire Earrings",
                        Description = "Sapphire Earrings",
                        Category = "Earrings",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Amethyst Barrel Necklace",
                        Description = "Amethyst Necklace",
                        Category = "Necklace",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Amethyst Barrel Necklace",
                        Description = "Amethyst Necklace",
                        Category = "Necklace",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Amethyst Rose Petal Earrings",
                        Description = "Rose petal earrings",
                        Category = "Earrings",
                        Price = 15
                    },

                    new Product
                    {
                        Name = "Amethyst Barrel Necklace",
                        Description = "Amethyst Necklace",
                        Category = "Necklace",
                        Price = 15
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
