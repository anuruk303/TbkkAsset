﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinAsset_Emp
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int id, String num)
        {
            Num = num;
            ID = id;
            Asset = await _context.Asset.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            return Page();
        }

        [BindProperty]
        public Join_Asset_Emp Join_Asset_Emp { get; set; }
        public IList<Asset> Asset { get; set; }
        public string Num { get; set; }
        public int ID { get;set; }
        public IList<Employee> Employee { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var AssetUpdate = await _context.Asset.FindAsync(Join_Asset_Emp.Asset_AssetID);
            AssetUpdate.Status = "Using";
            await _context.SaveChangesAsync();
            _context.Join_Asset_Emp.Add(Join_Asset_Emp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}