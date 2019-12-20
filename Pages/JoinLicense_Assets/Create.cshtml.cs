using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinLicense_Assets
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["License_LicenseID"] = new SelectList(_context.License, "LicenseID", "Attachfiles");
            return Page();
        }

        [BindProperty]
        public Join_License_Asset Join_License_Asset { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Join_License_Asset.Add(Join_License_Asset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}