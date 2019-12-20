using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinNetwork_Assets
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Join_Network_Asset> Join_Network_Asset { get;set; }

        public async Task OnGetAsync()
        {
            Join_Network_Asset = await _context.Join_Network_Asset
                .Include(j => j.Asset)
                .Include(j => j.Network).ToListAsync();
        }
    }
}
