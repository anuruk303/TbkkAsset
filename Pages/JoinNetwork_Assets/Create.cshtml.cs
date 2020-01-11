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
            Network = await _context.Network.ToListAsync();
            return Page();
        }

        [BindProperty]
        public Join_Network_Asset Join_Network_Asset { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<Network> Network { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Join_Network_Asset.Add(Join_Network_Asset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}