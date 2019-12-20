using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinNetwork_Assets
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
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
           ViewData["Asset_AssetID"] = new SelectList(_context.Asset, "AssetID", "AssetName");
           ViewData["Network_NetworkID"] = new SelectList(_context.Network, "NetworkID", "IpAddr");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Join_Network_Asset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Join_Network_AssetExists(Join_Network_Asset.JoinNetAsID))
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

        private bool Join_Network_AssetExists(int id)
        {
            return _context.Join_Network_Asset.Any(e => e.JoinNetAsID == id);
        }
    }
}
