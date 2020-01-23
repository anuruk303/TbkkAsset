using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.UpdateAssets
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Update_Asset Update_Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Update_Asset = await _context.Update_Asset.FirstOrDefaultAsync(m => m.UpdateAssetID == id);

            if (Update_Asset == null)
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

            _context.Attach(Update_Asset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Update_AssetExists(Update_Asset.UpdateAssetID))
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

        private bool Update_AssetExists(int id)
        {
            return _context.Update_Asset.Any(e => e.UpdateAssetID == id);
        }
    }
}
