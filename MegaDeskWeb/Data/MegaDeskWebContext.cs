using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Models
{
    public class MegaDeskWebContext : DbContext
    {
        public MegaDeskWebContext (DbContextOptions<MegaDeskWebContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskWeb.Models.Desk> Desk { get; set; }

        public DbSet<MegaDeskWeb.Models.Quote> Quote { get; set; }
        public DbSet<MegaDeskWeb.Models.Delivery> Delivery { get; set; }

        public DbSet<MegaDeskWeb.Models.SurfaceMaterial> SurfaceMaterial { get; set; }
    }
}
