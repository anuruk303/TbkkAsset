using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Licenses
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public License License { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Join_License_Asset> Join_License_Asset { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<Update_License> Update_License { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Update_License = await _context.Update_License.ToListAsync();
            Model = await _context.Model.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Join_License_Asset = await _context.Join_License_Asset.ToListAsync();
            Asset = await _context.Asset.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            License = await _context.License.FirstOrDefaultAsync(m => m.LicenseID == id);

            if (License == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
