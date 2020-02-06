using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkk_ACContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkk_ACContext>>()))
            {
                // Look for any movies.
                if (context.Brand.Any())
                {
                    return;   // DB has been seeded
                }

                context.Brand.AddRange(
                    new Brand
                    {
                        BrandName = "Intel",
                        Image = "Intel_Inside.jpg",
                        Status = "Using",
                    }




                );
                context.SaveChanges();
            }
        }
    }
}
