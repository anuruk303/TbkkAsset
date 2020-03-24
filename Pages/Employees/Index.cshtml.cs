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

namespace tbkk_AC.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee
                .Include(e => e.Company)
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).ToListAsync();
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
                        _context.Employee.AddRange(
                                            new Employee
                                            {
                                                FirstName = values[0],
                                                LastName = values[1],
                                                Gender = values[2],
                                                Email = values[3],
                                                Call = values[4],
                                                Line = values[5],
                                                Image = values[6],
                                                Addr = values[7],
                                                Date = DateTime.Parse(values[8]),
                                                Status = "Using",
                                                Company_CompanyID = Int32.Parse(values[9]),
                                                Department_DepartmentID = Int32.Parse(values[10]),
                                                Location_LocationID = Int32.Parse(values[11]),
                                                EmployeeType_EmployeeTypeID = Int32.Parse(values[12]),
                                                Position_PositionID = Int32.Parse(values[13])
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

        private int Parse(object p)
        {
            throw new NotImplementedException();
        }
    }
}
