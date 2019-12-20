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
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

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
    }
}
