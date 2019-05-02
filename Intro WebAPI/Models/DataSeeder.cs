using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_WebAPI.Models
{
    public class DataSeeder
    {
        public static void Initialize(IntroDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any cakes.
            if (context.Cakes.Any())
            {
                return;   // DB has been seeded
            }

            context.Cakes.AddRange(
                new Cake
                {
                    Name = "Tiramisu",
                    Ingredients = "Cheese, Coffee",
                    Calories = 500.50,
                    Inventor = "A great person"
                },
                new Cake
                {
                    Name = "Eclair",
                    Ingredients = "Cream, Chocolate",
                    Calories = 672,
                    Inventor = "Another great person"
                });
            context.SaveChanges();
        }

    }
}
