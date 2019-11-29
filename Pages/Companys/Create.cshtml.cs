using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Companys
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;
        private IHostingEnvironment environment;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormFile photo)
        {
            var file = Path.Combine(environment.ContentRootPath, "wwwroot/uploads", photo.FileName);
            var fileStream = new FileStream(file, FileMode.Create);
            Company.Image = photo.FileName;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Company.Add(Company);
            await _context.SaveChangesAsync();
            await photo.CopyToAsync(fileStream);
            return RedirectToPage("./Index");
        }
    }
}