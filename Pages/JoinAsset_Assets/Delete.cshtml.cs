using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinAsset_Assets
{
    public class DeleteModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DeleteModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Join_Asset_Asset Join_Asset_Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Join_Asset_Asset = await _context.Join_Asset_Asset.FirstOrDefaultAsync(m => m.JoinAsAsID == id);

            if (Join_Asset_Asset == null)
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

            Join_Asset_Asset = await _context.Join_Asset_Asset.FindAsync(id);
            Join_Asset_Asset.Status = "UNJOIN";
            if (Join_Asset_Asset != null)
            {
                _context.Attach(Join_Asset_Asset).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("../Licenses/Index");
        }
    }
}
