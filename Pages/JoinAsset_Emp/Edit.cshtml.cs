using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinAsset_Emp
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Join_Asset_Emp Join_Asset_Emp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Join_Asset_Emp = await _context.Join_Asset_Emp
                .Include(j => j.Asset)
                .Include(j => j.Employee).FirstOrDefaultAsync(m => m.JoinAsEmpID == id);

            if (Join_Asset_Emp == null)
            {
                return NotFound();
            }
           ViewData["Asset_AssetID"] = new SelectList(_context.Asset, "AssetID", "AssetName");
           ViewData["Employee_EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "EmployeeID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Join_Asset_Emp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Join_Asset_EmpExists(Join_Asset_Emp.JoinAsEmpID))
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

        private bool Join_Asset_EmpExists(int id)
        {
            return _context.Join_Asset_Emp.Any(e => e.JoinAsEmpID == id);
        }
    }
}
