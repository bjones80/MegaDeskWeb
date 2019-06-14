using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskWebContext>>()))
            {
                /*
                // Look for any movies.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        CustomerName = "Breena",
                        QuoteDate = DateTime.Parse("2019-1-1"),
                        DeskPrice = 344
                    }
                ); 
                // Look for any movies.
                if (context.Desk.Any())
                {
                    return;   // DB has been seeded
                }

                context.Desk.AddRange(
                    new Desk
                    {
                        Width = 34,
                        Depth = 45,
                        NumDrawers = 4,
                    }
                );
                // Look for any movies.
                */
                // Look for any surface material.
                if (context.SurfaceMaterial.Any())
                {
                    return;   // DB has been seeded
                }

                context.SurfaceMaterial.AddRange(
                    new SurfaceMaterial
                    {  
                        SurfaceMaterialName = "Oak",
                        SurfaceMaterialPrice = 200
                    },
                    new SurfaceMaterial
                    {
                        SurfaceMaterialName = "Laminate",
                        SurfaceMaterialPrice = 100
                    },
                    new SurfaceMaterial
                    {
                        SurfaceMaterialName = "Pine",
                        SurfaceMaterialPrice = 50
                    },
                    new SurfaceMaterial
                    {
                        SurfaceMaterialName = "RoseWood",
                        SurfaceMaterialPrice = 300
                    },
                    new SurfaceMaterial
                    {
                        SurfaceMaterialName = "Veneer",
                        SurfaceMaterialPrice = 125
                    }
                );
                // Look for any delivery.
                if (context.Delivery.Any())
                {
                    return;   // DB has been seeded
                }

                context.Delivery.AddRange(
                    new Delivery
                    {
                        DeliveryName = "3 Day",
                        LessThan1000 = 60,
                        From1000To2000 = 70,
                        GreaterThan2000 = 80
                    },
                    new Delivery
                    {
                        DeliveryName = "5 Day",
                        LessThan1000 = 40,
                        From1000To2000 = 50,
                        GreaterThan2000 = 60
                    },
                    new Delivery
                    {
                        DeliveryName = "7 Day",
                        LessThan1000 = 30,
                        From1000To2000 = 35,
                        GreaterThan2000 = 40
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
