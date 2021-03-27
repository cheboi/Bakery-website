using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Carrot Cake",
                    Description = "A scrumptious mini-carrot cake encrusted with sliced almonds",
                    Price = 899m,
                    ImageName = "Carrot_Cake.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Lemon Tart",
                    Description = "A delicious lemon tart with fresh meringue cooked to perfection",
                    Price = 999m,
                    ImageName = "lemon_tart.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Cupcakes",
                    Description = "Delectable vanilla and chocolate cupcakes",
                    Price = 599m,
                    ImageName = "cupcakes.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Bread",
                    Description = "Fresh baked French-style bread",
                    Price = 55m,
                    ImageName = "bread.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Pear Tart",
                    Description = "A glazed pear tart topped with sliced almonds and a dash of cinnamon",
                    Price = 599m,
                    ImageName = "pear_tart.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Chocolate Cake",
                    Description = "Rich chocolate frosting cover this chocolate lover's dream",
                    Price = 899m,
                    ImageName = "chocolate_cake.jpg"
                }
                );
            return modelBuilder;
        }
    }
}
