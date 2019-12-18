using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.UpdateLicenes
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Update_License Update_License { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Update_License = await _context.Update_License.FirstOrDefaultAsync(m => m.UpdateLicenseID == id);

            if (Update_License == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
