using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public EditModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Quote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.QuoteId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.QuoteId == id);
        }
    }
}
