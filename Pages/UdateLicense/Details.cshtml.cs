using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.UdateLicense
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Update_License Update_License { get; set; }
        public IList<License> License { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Asset> Asset { get; set; }

        public IList<Employee> Employee { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Employee = await _context.Employee.ToListAsync();
            License = await _context.License.ToListAsync();
            Model = await _context.Model.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Asset = await _context.Asset.ToListAsync();
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
