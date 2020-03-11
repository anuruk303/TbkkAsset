using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;
namespace tbkk_AC.Pages
{
    public class chart1
    {
        public int y { get; set; }
        public string label { get; set; }

    }
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;
        
        

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        
        public IList<Asset> Asset { get; set; }
        public IList<Employee> T { get; set; }
        public IList<chart1> chart1 { get; set; }

       

        public async Task OnGetAsync()
        {
 
            Asset = await _context.Asset.ToListAsync();
            

        }
    }
}
