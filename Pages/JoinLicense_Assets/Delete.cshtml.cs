using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinLicense_Assets
{
    public class DeleteModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DeleteModel(tbkk_AC.Models.tbkk_ACContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Join_License_Asset = await _context.Join_License_Asset.FindAsync(id);
            Join_License_Asset.Status = "UNJOIN";
            if (Join_License_Asset != null)
            {
                _context.Attach(Join_License_Asset).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("../Licenses/Index");
        }
    }
}
