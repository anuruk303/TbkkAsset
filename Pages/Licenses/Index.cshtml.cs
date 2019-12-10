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
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<License> License { get;set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public async Task OnGetAsync()
        {
            Model = await _context.Model.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            License = await _context.License.ToListAsync();
        }
    }
}
