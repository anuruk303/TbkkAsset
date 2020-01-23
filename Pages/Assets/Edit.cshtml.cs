using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Assets
{
    public class EditModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public EditModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Asset Asset { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Update_Asset> Update_Asset { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Update_Asset = await _context.Update_Asset.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Model = await _context.Model.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Asset.FirstOrDefaultAsync(m => m.AssetID == id);

            if (Asset == null)
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

            _context.Attach(Asset).State = EntityState.Modified;
            var Update = new Update_Asset();
            Update.Date = DateTime.Now;
            Update.Asset_AssetID = Asset.AssetID;
            Update.Employee_EmpID = 2012;
            Update.AssetName = Asset.AssetName;
            Update.SerailNumber = Asset.SerailNumber;
            Update.MACAddr = Asset.MACAddr;
            Update.InstallDate = Asset.InstallDate;
            Update.PurchaseDate = Asset.PurchaseDate;
            Update.ExpireDate = Asset.ExpireDate;
            Update.PONumber = Asset.PONumber;
            Update.Price = Asset.Price;
            Update.Warranty = Asset.Warranty;
            Update.Type = Asset.Type;
            Update.Note = Asset.Note;
            Update.Status = Asset.Status;
            Update.Image = Asset.Image;
            Update.Company_CompanyID = Asset.Company_CompanyID;
            Update.Location_LocationID = Asset.Location_LocationID;
            Update.Department_DepartmentID = Asset.Department_DepartmentID;
            Update.Supplier_SupplierID = Asset.Supplier_SupplierID;
            Update.Model_ModelID = Asset.Model_ModelID;
            _context.Update_Asset.Add(Update);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetExists(Asset.AssetID))
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

        private bool AssetExists(int id)
        {
            return _context.Asset.Any(e => e.AssetID == id);
        }
    }
}
