using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }
        public IList<Company> Company { get; set; }
        public IList<Department> Department { get; set; }
        public IList<EmployeeType> EmployeeType { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            EmployeeType = await _context.EmployeeType.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }
        private IHostingEnvironment environment;
        public async Task<IActionResult> OnPostAsync(IFormFile photo)
        {
            var file = Path.Combine(environment.ContentRootPath, "wwwroot/uploads", photo.FileName);
            var fileStream = new FileStream(file, FileMode.Create);
            Employee.Image = photo.FileName;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();
            await photo.CopyToAsync(fileStream);
            return RedirectToPage("./Index");
        }
    }
}