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
        public IList<Category> Category { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Category = await _context.Category.ToListAsync();
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
            var Update = new Update_Asset();
            Update.UpdateDate = DateTime.Now;
            Update.Asset_AssetID = Asset.AssetID;
            Update.Employee_EmpID = 2012;
            Update.UpdateAssetName = Asset.AssetName;
            Update.UpdateSerailNumber = Asset.SerailNumber;
            Update.UpdateMACAddr = Asset.MACAddr;
            Update.UpdateInstallDate = Asset.InstallDate;
            Update.UpdatePurchaseDate = Asset.PurchaseDate;
            Update.UpdateExpireDate = Asset.ExpireDate;
            Update.UpdatePONumber = Asset.PONumber;
            Update.UpdatePrice = Asset.Price;
            Update.UpdateWarranty = Asset.Warranty;
            Update.Category = Asset.Category;
            Update.UpdateNote = Asset.Note;
            Update.UpdateStatus = Asset.Status;
            Update.UpdateImage = Asset.Image;
            Update.Company_CompanyID = Asset.Company_CompanyID;
            Update.Location_LocationID = Asset.Location_LocationID;
            Update.Department_DepartmentID = Asset.Department_DepartmentID;
            Update.Supplier_SupplierID = Asset.Supplier_SupplierID;
            Update.Model_ModelID = Asset.Model_ModelID;
            _context.Update_Asset.Add(Update);
            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }

        private bool AssetExists(int id)
        {
            return _context.Asset.Any(e => e.AssetID == id);
        }
    }
}