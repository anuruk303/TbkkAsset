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
namespace tbkk_AC.Pages
{
    public class chart1
    {
        public int y { get; set; }
        public string label { get; set; }

    }
    public class chart2
    {
        public int y { get; set; }
        public string label { get; set; }

    }
    public class chart3
    {
        public int y { get; set; }
        public string label { get; set; }

    }
    public class status
    {
        public int Instock { get; set; }
        public int Using { get; set; }

        public string Name { get; set; }
    }
    public class statusLicense
    {
        public int Instock { get; set; }
        public int Using { get; set; }

        public string Name { get; set; }
    }
    public class statusEmployee
    {
       
        public int Using { get; set; }

        public string Name { get; set; }
    }

    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public int Asset_All { get; set; }
        public int License_All { get; set; }
        public int Network_All { get; set; }
        public int Employee_All { get; set; }

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        public IList<Asset> Asset { get; set; }
        public IList<Category> Category { get; set; }
        public IList<Employee> Employee { get; set; }
        public IList<License> License { get; set; }
        public IList<Network> Network { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<chart1> chart1 { get; set; }
        public IList<chart2> chart2 { get; set; }
        public IList<chart3> chart3 { get; set; }
        public IList<status> status { get; set; }
        public IList<statusLicense> statusLicense { get; set; }
        public IList<statusEmployee> statusEmployee { get; set; }
        private List<chart1> Chart1(List<Asset> Asset, List<Category> Category)
        {

            var listChart = new List<chart1>();
            foreach (var item in Category)
            {
                if (!item.Status.Equals("Unused"))
                {
                    var char1add = new chart1();
                    var num = 0;
                    foreach (var item1 in Asset)
                    {
                        if (!item1.Status.Equals("Unused"))
                        {
                            if (item.CategoryID == item1.Category)
                            {
                                num++;
                            }
                        }

                    }
                    if (num != 0)
                    {
                        char1add.label = item.CategoryName;
                        char1add.y = num;
                        listChart.Add(char1add);
                    }



                }
            }


            return listChart;
        }
        private List<chart2> Chart2(List<License> License, List<Supplier> Supplier)
        {

            var listChart = new List<chart2>();
            foreach (var item in Supplier)
            {
                if (!item.Status.Equals("Unused"))
                {

                    var char1add = new chart2();
                    var num = 0;
                    foreach (var item1 in License)
                    {
                        if (!item1.Status.Equals("Unused"))
                        {
                            if (item.SupplierID == item1.Supplier_SupplierID)
                            {
                                num++;
                            }
                        }
                    }
                    if (num != 0)
                    {

                        char1add.label = item.SupplierName;
                        char1add.y = num;
                        listChart.Add(char1add);
                    }



                }
            }


            return listChart;
        }
        private List<chart3> Chart3(List<Employee> Employee, List<Department> Department)
        {

            var listChart = new List<chart3>();
            foreach (var item in Department)
            {
                if (!item.Status.Equals("Unused"))
                {

                    var char1add = new chart3();
                    var num = 0;
                    foreach (var item1 in Employee)
                    {
                        if (!item1.Status.Equals("Unused"))
                        {
                            if (item.DepartmentID == item1.Department_DepartmentID)
                            {
                                num++;
                            }
                        }
                    }
                    if (num != 0)
                    {

                        char1add.label = item.DepartmentName;
                        char1add.y = num;
                        listChart.Add(char1add);
                    }



                }
            }


            return listChart;
        }
        private List<status> Status(List<Asset> Asset, List<Category> Category)
        {
            var listStatus = new List<status>();
            foreach (var item in Category)
            {
                if (!item.Status.Equals("Unused"))
                {
                    var i = 0;
                    var u = 0;
                    var Statusadd = new status();
                    foreach (var item1 in Asset)
                    {
                        if (item1.Category.Equals(item.CategoryID) && item1.Status.Equals("InStock"))
                        {
                            i++;
                        }
                        if (item.CategoryID.Equals(item1.Category) && item1.Status.Equals("Using"))
                        {
                            u++;
                        }
                    }
                    if (i != 0 || u != 0)
                    {
                        Statusadd.Instock = i;
                        Statusadd.Using = u;
                        Statusadd.Name = item.CategoryName;
                        listStatus.Add(Statusadd);
                    }
                }


            }
            return listStatus;
        }
        private List<statusLicense> StatusLicense(List<License> License, List<Supplier> Supplier)
        {
            var listStatus = new List<statusLicense>();
            foreach (var item in Supplier)
            {
                if (!item.Status.Equals("Unused"))
                {
                    var i = 0;
                    var u = 0;
                    var Statusadd = new statusLicense();
                    foreach (var item1 in License)
                    {
                        if (item1.Supplier_SupplierID.Equals(item.SupplierID) && item1.Status.Equals("InStock"))
                        {
                            i++;
                        }
                        if (item.SupplierID.Equals(item1.Supplier_SupplierID) && item1.Status.Equals("Using"))
                        {
                            u++;
                        }
                    }
                    if(i!=0||u!=0){
                        Statusadd.Instock = i;
                        Statusadd.Using = u;
                        Statusadd.Name = item.SupplierName;
                        listStatus.Add(Statusadd);
                    }
                }


            }
            return listStatus;
        }
        private List<statusEmployee> StatusEmployee(List<Employee> Employee, List<Department> Department)
        {
            var listStatus = new List<statusEmployee>();
            foreach (var item in Department)
            {
                if (!item.Status.Equals("Unused"))
                {
                    var i = 0;
                   
                    var Statusadd = new statusEmployee();
                    foreach (var item1 in Employee)
                    {
                        if (item1.Department_DepartmentID.Equals(item.DepartmentID) && !item1.Status.Equals("Unused"))
                        {
                            i++;
                        }
                        
                    }
                    if (i != 0)
                    {
                        Statusadd.Using = i;
                        Statusadd.Name = item.DepartmentName;
                        listStatus.Add(Statusadd);
                    }
                }


            }
            return listStatus;
        }

        public async Task OnGetAsync()
        {
            
            var Category1 = _context.Category.ToList();
            var Employee1 = _context.Employee.ToList();
            var Asset1 = _context.Asset.ToList();
            var Department1 = _context.Department.ToList();
            var License1 = _context.License.ToList();
            var Supplier1 = _context.Supplier.ToList();
            Employee = await _context.Employee.ToListAsync();
            Network = await _context.Network.ToListAsync();
            License = await _context.License.ToListAsync();
            Asset = await _context.Asset.ToListAsync();
            Category = await _context.Category.ToListAsync();
            Department = await _context.Department.ToListAsync();
            chart1 = Chart1(Asset1, Category1);
            chart2 = Chart2(License1, Supplier1);
            chart3 = Chart3(Employee1, Department1);
            status = Status(Asset1, Category1);
            statusLicense = StatusLicense(License1, Supplier1);
            statusEmployee = StatusEmployee(Employee1, Department1);
            foreach (var item in Asset)
            {
                if (!item.Status.Equals("Unused"))
                {
                    Asset_All++;
                }

            }
            foreach (var item in Network)
            {
                if (!item.Status.Equals("Unused"))
                {
                    Network_All++;
                }

            }
            foreach (var item in License)
            {
                if (!item.Status.Equals("Unused"))
                {
                    License_All++;
                }

            }
            foreach (var item in Employee)
            {
                if (!item.Status.Equals("Unused"))
                {
                    Employee_All++;
                }

            }



        }
    }
}

