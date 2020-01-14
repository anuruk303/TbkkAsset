using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Department> Department { get; set; }
        public IList<EmployeeType> EmployeeType { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            EmployeeType = await _context.EmployeeType.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);


            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
