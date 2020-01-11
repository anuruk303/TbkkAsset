using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinAsset_Emp
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Join_Asset_Emp Join_Asset_Emp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Join_Asset_Emp = await _context.Join_Asset_Emp
                .Include(j => j.Asset).FirstOrDefaultAsync(m => m.JoinAsEmpID == id);

            if (Join_Asset_Emp == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
