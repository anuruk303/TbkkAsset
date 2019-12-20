using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinAsset_Emp
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Asset_AssetID"] = new SelectList(_context.Asset, "AssetID", "AssetName");
        ViewData["Employee_EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "EmployeeID");
            return Page();
        }

        [BindProperty]
        public Join_Asset_Emp Join_Asset_Emp { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Join_Asset_Emp.Add(Join_Asset_Emp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}