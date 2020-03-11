using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.UdateAsset
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Update_Asset Update_Asset { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Asset>  Asset { get; set; }
        public IList<Join_Asset_Emp> Join_Asset_Emp { get; set; }
        public IList<Join_Asset_Asset> Join_Asset_Asset { get; set; }
        public IList<Join_License_Asset> Join_License_Asset { get; set; }
        public IList<Join_Network_Asset> Join_Network_Asset { get; set; }
        public IList<License> License { get; set; }
        public IList<Employee> Employee { get; set; }
        public IList<Network> Network { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Asset = await _context.Asset.ToListAsync();
            License = await _context.License.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Network = await _context.Network.ToListAsync();
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

            Update_Asset = await _context.Update_Asset.FirstOrDefaultAsync(m => m.UpdateAssetID == id);

            if (Update_Asset == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
