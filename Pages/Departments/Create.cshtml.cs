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

namespace tbkk_AC.Pages.Departments
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
        public Department Department { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormFile photo)
        {
            var file = Path.Combine(environment.ContentRootPath, "wwwroot/uploads", photo.FileName);
            var fileStream = new FileStream(file, FileMode.Create);
            Department.Image = photo.FileName;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Department.Add(Department);
            await _context.SaveChangesAsync();
            await photo.CopyToAsync(fileStream);
            return RedirectToPage("./Index");
        }
    }
}