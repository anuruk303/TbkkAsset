using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinLicense_Assets
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Join_License_Asset Join_License_Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Join_License_Asset = await _context.Join_License_Asset
                .Include(j => j.License).FirstOrDefaultAsync(m => m.JoinLiAsID == id);

            if (Join_License_Asset == null)
            {
                return NotFound();
            }
           ViewData["License_LicenseID"] = new SelectList(_context.License, "LicenseID", "Attachfiles");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Join_License_Asset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Join_License_AssetExists(Join_License_Asset.JoinLiAsID))
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

        private bool Join_License_AssetExists(int id)
        {
            return _context.Join_License_Asset.Any(e => e.JoinLiAsID == id);
        }
    }
}
