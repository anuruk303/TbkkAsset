using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Update_Licenses
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            License = await _context.License.FirstOrDefaultAsync(m => m.LicenseID == id);

            if (License == null)
            {
                return NotFound();
            }
            return Page();

        }

        [BindProperty]
        public Update_License Update_License { get; set; }
        public License License { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Update_License.Add(Update_License);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}