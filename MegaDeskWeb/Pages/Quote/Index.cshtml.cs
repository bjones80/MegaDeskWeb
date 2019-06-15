using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public IndexModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get; set; }
        public IList<MegaDeskWeb.Models.Desk> Desk{ get; set; }
        public IList<SurfaceMaterial> SurfaceMaterial { get; set; }
        public IList<Delivery> Delivery { get; set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
            Desk = await _context.Desk.ToListAsync();
            SurfaceMaterial = await _context.SurfaceMaterial.ToListAsync();
            Delivery = await _context.Delivery.ToListAsync();
        }
    }
}
