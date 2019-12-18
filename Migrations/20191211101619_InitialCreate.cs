using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tbkk_AC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: false),
                    TypeName = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    EmployeeTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.EmployeeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    LicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LicenseName = table.Column<string>(nullable: false),
                    SoftewareName = table.Column<string>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: false),
                    Attachfiles = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Model_ModelID = table.Column<int>(nullable: false),
                    Supplier_SupplierID = table.Column<int>(nullable: false),
                    Department_DepartmentID = table.Column<int>(nullable: false),
                    Company_CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.LicenseID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Network",
                columns: table => new
                {
                    NetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NetworkName = table.Column<string>(nullable: false),
                    IpAddr = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Network", x => x.NetworkID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Update_License",
                columns: table => new
                {
                    UpdateLicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    LicenseName = table.Column<string>(nullable: false),
                    SoftewareName = table.Column<string>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: false),
                    Attachfiles = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Employee = table.Column<string>(nullable: false),
                    Model_ModelID = table.Column<int>(nullable: false),
                    Supplier_SupplierID = table.Column<int>(nullable: false),
                    Department_DepartmentID = table.Column<int>(nullable: false),
                    Company_CompanyID = table.Column<int>(nullable: false),
                    License_LicenseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Update_License", x => x.UpdateLicenseID);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    ModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Brand_BrandID = table.Column<int>(nullable: false),
                    Category_CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Model_Brand_Brand_BrandID",
                        column: x => x.Brand_BrandID,
                        principalTable: "Brand",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Model_Category_Category_CategoryID",
                        column: x => x.Category_CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Addr = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Company_CompanyID = table.Column<int>(nullable: false),
                    Department_DepartmentID = table.Column<int>(nullable: false),
                    Location_LocationID = table.Column<int>(nullable: false),
                    EmployeeType_EmployeeTypeID = table.Column<int>(nullable: false),
                    Position_PositionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Company_Company_CompanyID",
                        column: x => x.Company_CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Department_Department_DepartmentID",
                        column: x => x.Department_DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_EmployeeType_EmployeeTypeID",
                        column: x => x.EmployeeType_EmployeeTypeID,
                        principalTable: "EmployeeType",
                        principalColumn: "EmployeeTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Location_Location_LocationID",
                        column: x => x.Location_LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_Position_PositionID",
                        column: x => x.Position_PositionID,
                        principalTable: "Position",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    AssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetName = table.Column<string>(nullable: false),
                    SerailNumber = table.Column<string>(nullable: false),
                    MACAddr = table.Column<string>(nullable: false),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Company_CompanyID = table.Column<int>(nullable: false),
                    Location_LocationID = table.Column<int>(nullable: false),
                    Department_DepartmentID = table.Column<int>(nullable: false),
                    Supplier_SupplierID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.AssetID);
                    table.ForeignKey(
                        name: "FK_Asset_Supplier_Supplier_SupplierID",
                        column: x => x.Supplier_SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Asset_Asset",
                columns: table => new
                {
                    JoinAsAsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Asset_AssetID = table.Column<int>(nullable: false),
                    AssetMomAssetID = table.Column<int>(nullable: true),
                    AssetSon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Asset_Asset", x => x.JoinAsAsID);
                    table.ForeignKey(
                        name: "FK_Join_Asset_Asset_Asset_AssetMomAssetID",
                        column: x => x.AssetMomAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Supplier_SupplierID",
                table: "Asset",
                column: "Supplier_SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Company_CompanyID",
                table: "Employee",
                column: "Company_CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Department_DepartmentID",
                table: "Employee",
                column: "Department_DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeType_EmployeeTypeID",
                table: "Employee",
                column: "EmployeeType_EmployeeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Location_LocationID",
                table: "Employee",
                column: "Location_LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Position_PositionID",
                table: "Employee",
                column: "Position_PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Asset_Asset_AssetMomAssetID",
                table: "Join_Asset_Asset",
                column: "AssetMomAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Model_Brand_BrandID",
                table: "Model",
                column: "Brand_BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Model_Category_CategoryID",
                table: "Model",
                column: "Category_CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Join_Asset_Asset");

            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Network");

            migrationBuilder.DropTable(
                name: "Update_License");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
