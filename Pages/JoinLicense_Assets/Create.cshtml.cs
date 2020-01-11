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
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Asset = await _context.Asset.ToListAsync();
            License = await _context.License.ToListAsync();
            return Page();
        }

        [BindProperty]
        public Join_License_Asset Join_License_Asset { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<License> License { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Join_License_Asset.Add(Join_License_Asset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}