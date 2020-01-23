using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.UpdateNetwork
{
    public class DeleteModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DeleteModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Update_Network Update_Network { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Update_Network = await _context.Update_Network.FindAsync(id);

            if (Update_Network != null)
            {
                _context.Update_Network.Remove(Update_Network);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
