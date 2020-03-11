using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.UpdateNetworks
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Update_Network Update_Network { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<Employee> Employee { get; set; }
        public IList<Network> Network { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Asset = await _context.Asset.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Network = await _context.Network.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Update_Network = await _context.Update_Network.FirstOrDefaultAsync(m => m.NetworkUpdateID == id);

            if (Update_Network == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
