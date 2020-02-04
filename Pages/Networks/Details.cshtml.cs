using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Networks
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Network Network { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<Join_Network_Asset> Join_Network_Asset { get; set; }
       
        public async Task<IActionResult> OnGetAsync(int? id)
        {
         
            Asset = await _context.Asset.ToListAsync();
            Join_Network_Asset = await _context.Join_Network_Asset.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Network = await _context.Network.FirstOrDefaultAsync(m => m.NetworkID == id);

            if (Network == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
