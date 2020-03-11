using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Networks
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Network Network { get; set; }
        public IList<Update_Network> Update_Network { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Update_Network = await _context.Update_Network.ToListAsync();
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Network).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NetworkExists(Network.NetworkID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var Update = new Update_Network();

            Update.Date = DateTime.Now;
            Update.Network_NetworkID = Network.NetworkID;
            Update.Employee_EmpID = 2012;
            Update.NetworkName = Network.NetworkName;
            Update.IpAddr = Network.IpAddr;
            Update.Note = Network.Note;
            Update.Password = Network.Password;
            Update.Status = Network.Status;
            _context.Update_Network.Add(Update);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool NetworkExists(int id)
        {
            return _context.Network.Any(e => e.NetworkID == id);
        }
    }
}