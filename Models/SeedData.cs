using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkk_ACContext(
                serviceProvider.GetRequiredService<DbContextOptions<tbkk_ACContext>>()))
            {
                // Look for any movies.

                if (context.EmployeeType.Any())
                {
                    return;   // DB has been seeded
                }

                context.Brand.AddRange(
                new Brand
                {
                    BrandName = "Intel",
                    Image = "pingpong.jpeg",
                    Status = "In stock"
                }
                );
                context.Brand.AddRange(
                new Brand
                {
                    BrandName = "Microsoft",
                    Image = "pingpong.jpeg",
                    Status = "In stock"
                }
                );
                context.Category.AddRange(
                new Category
                {
                    CategoryName = "Mouse",
                    Image = "pingpong.jpeg",
                    TypeName = "Accessory",
                    Status = "In stock"
                }
                );
                context.Category.AddRange(
                new Category
                {
                    CategoryName = "Microsoft Office",
                    Image = "pingpong.jpeg",
                    TypeName = "License",
                    Status = "In stock"
                }
                );
                context.Company.AddRange(
                new Company
                {
                    CompanyName = "Branch 1",
                    Image = "pingpong.jpeg",
                    Status = "Using"
                }
                );
                context.Company.AddRange(
                new Company
                {
                    CompanyName = "Branch 2",
                    Image = "pingpong.jpeg",
                    Status = "Using"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "IT Service",
                    Image = "pingpong.jpeg",
                    Status = "Using"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Human Resourse",
                    Image = "pingpong.jpeg",
                    Status = "Using"
                }
                );
                context.EmployeeType.AddRange(
                new EmployeeType
                {
                    EmployeeTypeName = "Full-time",
                    Status = "Using"
                }
                );
                context.EmployeeType.AddRange(
                new EmployeeType
                {
                    EmployeeTypeName = "Part-time",
                    Status = "Using"
                }
                );
                context.Location.AddRange(
                new Location
                {
                    LocationName = "building 1, Floor 2",
                    Note = "-",
                    Status = "Using"
                }
                );
                context.Location.AddRange(
                new Location
                {
                    LocationName = "building 2, Floor 2",
                    Note = "-",
                    Status = "Using"
                }
                );
                context.Network.AddRange(
                new Network
                {
                    NetworkName = "B2-F2",
                    IpAddr = "8888.8888.8888",
                    Note = "-",
                    Password = "pass",
                    Status = "Using"
                }
                );
                context.Network.AddRange(
                new Network
                {
                    NetworkName = "B2-F1",
                    IpAddr = "8888.8888.8888",
                    Note = "-",
                    Password = "pass",
                    Status = "Using"
                }
                );
                context.Position.AddRange(
                new Position
                {
                    PositionName = "personnel",
                    Status = "Using"
                }
                );
                context.Position.AddRange(
                new Position
                {
                    PositionName = "head",
                    Status = "Using"
                }
                );
                context.Supplier.AddRange(
                new Supplier
                {
                    SupplierName = "nan",
                    ContactName = "-",
                    Address = "-",
                    Email = "-",
                    URL = "-",
                    Image = "pingpong.jpeg",
                    Status = "Using"
                }
                );
                context.Supplier.AddRange(
                new Supplier
                {
                    SupplierName = "boom",
                    ContactName = "-",
                    Address = "-",
                    Email = "-",
                    URL = "-",
                    Image = "pingpong.jpeg",
                    Status = "Using"
                }
                );
                context.SaveChanges();
            }
            using (var context = new tbkk_ACContext(
                serviceProvider.GetRequiredService<DbContextOptions<tbkk_ACContext>>()))
            {
                // Look for any movies.

                if (context.EmployeeType.Any())
                {
                    return;   // DB has been seeded
                }
                context.Model.AddRange(
                new Model
                {
                    ModelName = "9300 dpi",
                    Note = "-",
                    Brand_BrandID = 1,
                    Category_CategoryID = 1,
                    Status = "Using"
                }
                );
                context.Model.AddRange(
                new Model
                {
                    ModelName = "-",
                    Note = "-",
                    Brand_BrandID = 2,
                    Category_CategoryID = 2,
                    Status = "Using"
                }
                );
                
                context.SaveChanges();
            }
            using (var context = new tbkk_ACContext(
               serviceProvider.GetRequiredService<DbContextOptions<tbkk_ACContext>>()))
            {
                // Look for any movies.

                if (context.EmployeeType.Any())
                {
                    return;   // DB has been seeded
                }
                context.Employee.AddRange(
                new Employee
                {
                    FirstName = "Nattatida",
                    LastName = "Srisa",
                    Gender = "Female",
                    Email = "ns@gmail.com",
                    Call = "092-381-3880",
                    Line = "xxxxxx",
                    Image = "pingpong.jpeg",
                    Addr = "Bangsean",
                    Date = DateTime.Parse("1989-2-12"),
                    Status = "Using",
                    Company_CompanyID = 1,
                    Department_DepartmentID = 1,
                    Location_LocationID = 1,
                    EmployeeType_EmployeeTypeID = 1,
                    Position_PositionID = 1
                }
                );
                context.Employee.AddRange(
                new Employee
                {
                    FirstName = "Chanon",
                    LastName = "Srisa",
                    Gender = "Male",
                    Email = "cs@gmail.com",
                    Call = "092-381-3881",
                    Line = "xxxxxx1",
                    Image = "pingpong.jpeg",
                    Addr = "Samutprakarn",
                    Date = DateTime.Parse("1989-2-11"),
                    Status = "Using",
                    Company_CompanyID = 2,
                    Department_DepartmentID = 2,
                    Location_LocationID = 2,
                    EmployeeType_EmployeeTypeID = 2,
                    Position_PositionID = 2
                }
                );
                context.License.AddRange(
                new License
                {
                    LicenseName = "xxx-xxx-xx",
                    SoftewareName = "office",
                    PurchaseDate = DateTime.Parse("2019-2-10"),
                    StartDate = DateTime.Parse("2019-2-20"),
                    ExpireDate = DateTime.Parse("2024-2-10"),
                    PONumber = "xxxxxx-xxx",
                    Attachfiles = "null",
                    Note = "-",
                    Status = "Using",
                    Model_ModelID = 2,
                    Supplier_SupplierID = 2,
                    Department_DepartmentID = 2,
                    Company_CompanyID = 2
                }
                );
                context.License.AddRange(
                new License
                {
                    LicenseName = "xxx-xxx-xx",
                    SoftewareName = "access",
                    PurchaseDate = DateTime.Parse("2019-2-10"),
                    StartDate = DateTime.Parse("2019-2-20"),
                    ExpireDate = DateTime.Parse("2024-2-20"),
                    PONumber = "xxxxxx-xxx",
                    Attachfiles = "null",
                    Note = "-",
                    Status = "Using",
                    Model_ModelID = 2,
                    Supplier_SupplierID = 2,
                    Department_DepartmentID = 2,
                    Company_CompanyID = 2
                }
                );
                context.Asset.AddRange(
                new Asset
                {
                    AssetName = "PC-001",
                    SerailNumber = "xxx-xxx-xx1",
                    MACAddr = "xxx.xxx.xxx",
                    InstallDate = DateTime.Parse("2019-2-20"),
                    PurchaseDate = DateTime.Parse("2019-2-10"),
                    ExpireDate = DateTime.Parse("2024-2-10"),
                    PONumber = "xxx-xxx-xxx",
                    Price = "19,200",
                    Warranty = 3,
                    Type = "Asset",
                    Note = "-",
                    Status = "Using",
                    Company_CompanyID = 2,
                    Location_LocationID = 2,
                    Department_DepartmentID = 2,
                    Supplier_SupplierID = 2,
                    Employee_EmployeeID = 1,
                    Image = "pingpong.jpeg"
                }
                );
                context.Asset.AddRange(
                new Asset
                {
                    AssetName = "KB-001",
                    SerailNumber = "xxx-xxx-xx1",
                    MACAddr = "xxx.xxx.xxx",
                    InstallDate = DateTime.Parse("2019-2-12"),
                    PurchaseDate = DateTime.Parse("2019-2-10"),
                    ExpireDate = DateTime.Parse("2024-2-12"),
                    PONumber = "xxx-xxx-xxx",
                    Price = "1,200",
                    Warranty = 1,
                    Type = "Accessory",
                    Note = "-",
                    Status = "Using",
                    Company_CompanyID = 2,
                    Location_LocationID = 2,
                    Department_DepartmentID = 2,
                    Supplier_SupplierID = 2,
                    Employee_EmployeeID = 1,
                    Image = "pingpong.jpeg"
                }
                );
                context.SaveChanges();
            }
            
        }
    }
}
