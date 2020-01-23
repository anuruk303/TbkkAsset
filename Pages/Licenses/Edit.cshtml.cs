using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Licenses
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public License License { get; set; }
        public Update_License Update_License { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Model = await _context.Model.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            License = await _context.License.FirstOrDefaultAsync(m => m.LicenseID == id);

            if (License == null)
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

           
            _context.Attach(License).State = EntityState.Modified;
            var Update = new Update_License();
            Update.Date = DateTime.Now;
            Update.License_LicenseID = License.LicenseID;
            Update.LicenseName = License.LicenseName;
            Update.SoftewareName = License.SoftewareName;
            Update.PurchaseDate = License.PurchaseDate;
            Update.StartDate = License.StartDate;
            Update.ExpireDate = License.ExpireDate;
            Update.PONumber = License.PONumber;
            Update.Attachfiles = License.Attachfiles;
            Update.Note = License.Note;
            Update.Status = License.Status;
            Update.Model_ModelID = License.Model_ModelID;
            Update.Supplier_SupplierID = License.Supplier_SupplierID;
            Update.Department_DepartmentID = License.Department_DepartmentID;
            Update.Company_CompanyID = License.Company_CompanyID;
            Update.Employee = 2012;
            _context.Update_License.Add(Update);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LicenseExists(License.LicenseID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LicenseExists(int id)
        {
            return _context.License.Any(e => e.LicenseID == id);
        }
    }
}
