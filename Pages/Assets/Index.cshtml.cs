using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Assets
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;
        private readonly IHostingEnvironment environment;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }

        public IList<Asset> Asset { get;set; }
        [BindProperty]
        public Asset AssetCreate { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Update_Asset> Update_Asset { get; set; }
        public IList<Category> Category { get; set; }
        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
            Update_Asset = await _context.Update_Asset.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Model = await _context.Model.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();
            Asset = await _context.Asset.ToListAsync();

        }
        
        public async Task<IActionResult> OnPostCreateAsync(IFormFile photo)
        {
            var file = Path.Combine(environment.ContentRootPath, "wwwroot/uploads", photo.FileName);
            var fileStream = new FileStream(file, FileMode.Create);
            var namePhoto = photo.FileName;
            AssetCreate.Image = photo.FileName;
            if (!ModelState.IsValid)
            {

            }
            _context.Asset.Add(AssetCreate);
            await _context.SaveChangesAsync();
            await photo.CopyToAsync(fileStream);
            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostImportAsync(IFormFile Excel)
        {
            using (var reader = new StreamReader(Excel.OpenReadStream()))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[0] != null)
                    {
                        _context.Asset.AddRange(
                                            new Asset
                                            {
                                                AssetName = values[0],
                                                SerailNumber = values[1],
                                                MACAddr = values[2],
                                                InstallDate = DateTime.Parse(values[3]),
                                                PurchaseDate = DateTime.Parse(values[4]),
                                                ExpireDate = DateTime.Parse(values[5]),
                                                PONumber = values[6],
                                                Price = values[7],
                                                Warranty = Int32.Parse(values[8]),
                                                Category = Int32.Parse(values[9]),
                                                Note = values[10],
                                                Status = "Using",
                                                Image = values[11],
                                                Company_CompanyID = Int32.Parse(values[12]),
                                                Location_LocationID = Int32.Parse(values[13]),
                                                Department_DepartmentID = Int32.Parse(values[14]),
                                                Supplier_SupplierID = Int32.Parse(values[15]),
                                                Model_ModelID = Int32.Parse(values[16])

                                            }
                                            );
                    }
                    else
                    {
                        break;
                    }
                }
            }

            _context.SaveChanges();

            return RedirectToPage("./Index");
        }

        private int Parse(string v)
        {
            throw new NotImplementedException();
        }
    }
}
