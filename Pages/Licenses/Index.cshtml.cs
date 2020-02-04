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

namespace tbkk_AC.Pages.Licenses
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<License> License { get; set; }
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
        public async Task<IActionResult> OnPostAsync(IFormFile Excel)
        {
            using (var reader = new StreamReader(Excel.OpenReadStream()))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[0] != null)
                    {
                        _context.License.AddRange(
                                            new License
                                            {
                                                LicenseName = values[0],
                                                SoftewareName = values[1],
                                                PurchaseDate = DateTime.Parse(values[2]),
                                                StartDate = DateTime.Parse(values[3]),
                                                ExpireDate = DateTime.Parse(values[4]),
                                                PONumber = values[5],
                                                Attachfiles = values[6],
                                                Note = values[7],
                                                Status = "Using",
                                                Model_ModelID = Int32.Parse(values[8]),
                                                Supplier_SupplierID = Int32.Parse(values[9]),
                                                Department_DepartmentID = Int32.Parse(values[10]),
                                                Company_CompanyID = Int32.Parse(values[11])

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