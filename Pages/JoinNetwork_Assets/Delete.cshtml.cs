using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinNetwork_Assets
{
    public class DeleteModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DeleteModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Join_Network_Asset Join_Network_Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Join_Network_Asset = await _context.Join_Network_Asset
                .Include(j => j.Asset)
                .Include(j => j.Network).FirstOrDefaultAsync(m => m.JoinNetAsID == id);

            if (Join_Network_Asset == null)
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

            Join_Network_Asset = await _context.Join_Network_Asset.FindAsync(id);

            if (Join_Network_Asset != null)
            {
                _context.Join_Network_Asset.Remove(Join_Network_Asset);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
