using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWeb.Models;

namespace MegaDeskWeb
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public CreateModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
            IQueryable<string> matQuery = from m in _context.SurfaceMaterial
                                          orderby m.SurfaceMaterialName
                                          select m.SurfaceMaterialName;

            SurfaceMaterials = new SelectList(matQuery.Distinct().ToList());

            IQueryable<string> deliQuery = from d in _context.Delivery
                                           orderby d.DeliveryName
                                           select d.DeliveryName;
            Deliverys = new SelectList(deliQuery.Distinct().ToList());
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Quote Quote { get; set; }
        public MegaDeskWeb.Models.Desk Desk { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public SelectList SurfaceMaterials { get; set; }
        public Delivery Delivery { get; set; }
        public SelectList Deliverys { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Quote.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}