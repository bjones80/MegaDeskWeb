﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public DetailsModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        public Quote Quote { get; set; }
        public MegaDeskWeb.Models.Desk Desk { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public Delivery Delivery { get; set; }



        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.FirstOrDefaultAsync(m => m.QuoteId == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
