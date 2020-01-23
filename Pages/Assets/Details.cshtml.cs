using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Assets
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public Asset Asset { get; set; }
        public IList<Join_Asset_Emp> Join_Asset_Emp { get; set; }
        public IList<Join_Asset_Asset> Join_Asset_Asset { get; set; }
        public IList<Join_License_Asset> Join_License_Asset { get; set; }
        public IList<Join_Network_Asset> Join_Network_Asset { get; set; }
        public IList<License> License { get; set; }
        public IList<Employee> Employee { get; set; }
        public IList<Network> Network { get; set; }
        public IList<Asset> Asset1 { get; set; }
        public IList<Update_Asset> Update_Asset { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Update_Asset =  await _context.Update_Asset.ToListAsync();
            License = await _context.License.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Network = await _context.Network.ToListAsync();
            Asset1 = await _context.Asset.ToListAsync();
            Join_Asset_Emp = await _context.Join_Asset_Emp.ToListAsync();
            Join_Asset_Asset = await _context.Join_Asset_Asset.ToListAsync();
            Join_License_Asset = await _context.Join_License_Asset.ToListAsync();
            Join_Network_Asset = await _context.Join_Network_Asset.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Model = await _context.Model.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Asset.FirstOrDefaultAsync(m => m.AssetID == id);

            if (Asset == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
