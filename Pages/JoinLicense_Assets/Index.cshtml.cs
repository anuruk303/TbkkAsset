using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinLicense_Assets
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Join_License_Asset> Join_License_Asset { get;set; }

        public async Task OnGetAsync()
        {
            Join_License_Asset = await _context.Join_License_Asset
                .Include(j => j.License).ToListAsync();
        }
    }
}
