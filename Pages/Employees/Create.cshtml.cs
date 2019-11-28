using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Employees
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
        ViewData["Company_CompanyID"] = new SelectList(_context.Company, "CompanyID", "Image");
        ViewData["Department_DepartmentID"] = new SelectList(_context.Department, "DepartmentID", "DepartmentName");
        ViewData["EmployeeType_EmployeeTypeID"] = new SelectList(_context.Set<EmployeeType>(), "EmployeeTypeID", "EmployeeTypeID");
        ViewData["Location_LocationID"] = new SelectList(_context.Location, "LocationID", "LocationName");
        ViewData["Position_PositionID"] = new SelectList(_context.Set<Position>(), "PositionID", "PositionID");
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}