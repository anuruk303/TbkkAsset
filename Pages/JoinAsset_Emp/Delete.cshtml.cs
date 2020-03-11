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
    public class DeleteModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DeleteModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Join_Asset_Emp Join_Asset_Emp { get; set; }
        public IList<Asset> Asset { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Asset = await _context.Asset.ToListAsync();
            Join_Asset_Emp = await _context.Join_Asset_Emp
                .Include(j => j.Asset).FirstOrDefaultAsync(m => m.JoinAsEmpID == id);

            if (Join_Asset_Emp == null)
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
            
            Join_Asset_Emp = await _context.Join_Asset_Emp.FindAsync(id);
            Join_Asset_Emp.Status = "UNJOIN";
            var AssetUpdate = await _context.Asset.FindAsync(Join_Asset_Emp.Asset_AssetID);
            AssetUpdate.Status = "InStock";
            await _context.SaveChangesAsync();
            if (Join_Asset_Emp != null)
            {
                _context.Attach(Join_Asset_Emp).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("../Employees/Index");
        }
    }
}
