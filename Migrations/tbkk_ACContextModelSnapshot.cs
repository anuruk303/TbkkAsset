﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tbkk_AC.Models;

namespace tbkk_AC.Migrations
{
    [DbContext(typeof(tbkk_ACContext))]
    partial class tbkk_ACContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tbkk_AC.Models.Asset", b =>
                {
                    b.Property<int>("AssetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetName")
                        .IsRequired();

                    b.Property<int>("Company_CompanyID");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<DateTime>("InstallDate");

                    b.Property<int>("Location_LocationID");

                    b.Property<string>("MACAddr")
                        .IsRequired();

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("PONumber")
                        .IsRequired();

                    b.Property<string>("Price")
                        .IsRequired();

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("SerailNumber")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Supplier_SupplierID");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("Warranty");

                    b.HasKey("AssetID");

                    b.HasIndex("Supplier_SupplierID");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("BrandID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("tbkk_AC.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("TypeName")
                        .IsRequired();

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("tbkk_AC.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("tbkk_AC.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("tbkk_AC.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addr");

                    b.Property<string>("Call");

                    b.Property<int>("Company_CompanyID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<string>("Email");

                    b.Property<int>("EmployeeType_EmployeeTypeID");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("Line");

                    b.Property<int>("Location_LocationID");

                    b.Property<int>("Position_PositionID");

                    b.Property<string>("Status");

                    b.HasKey("EmployeeID");

                    b.HasIndex("Company_CompanyID");

                    b.HasIndex("Department_DepartmentID");

                    b.HasIndex("EmployeeType_EmployeeTypeID");

                    b.HasIndex("Location_LocationID");

                    b.HasIndex("Position_PositionID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("tbkk_AC.Models.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeTypeName");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("EmployeeTypeID");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Asset_Asset", b =>
                {
                    b.Property<int>("JoinAsAsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssetMomAssetID");

                    b.Property<int>("AssetSon");

                    b.Property<int>("Asset_AssetID");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("JoinAsAsID");

                    b.HasIndex("AssetMomAssetID");

                    b.ToTable("Join_Asset_Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.License", b =>
                {
                    b.Property<int>("LicenseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachfiles")
                        .IsRequired();

                    b.Property<int>("Company_CompanyID");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("LicenseName")
                        .IsRequired();

                    b.Property<int>("Model_ModelID");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("PONumber")
                        .IsRequired();

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("SoftewareName")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Supplier_SupplierID");

                    b.HasKey("LicenseID");

                    b.ToTable("License");
                });

            modelBuilder.Entity("tbkk_AC.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .IsRequired();

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("tbkk_AC.Models.Model", b =>
                {
                    b.Property<int>("ModelID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Brand_BrandID");

                    b.Property<int>("Category_CategoryID");

                    b.Property<string>("ModelName");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("ModelID");

                    b.HasIndex("Brand_BrandID");

                    b.HasIndex("Category_CategoryID");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("tbkk_AC.Models.Network", b =>
                {
                    b.Property<int>("NetworkID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IpAddr")
                        .IsRequired();

                    b.Property<string>("NetworkName")
                        .IsRequired();

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("NetworkID");

                    b.ToTable("Network");
                });

            modelBuilder.Entity("tbkk_AC.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("PositionID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("tbkk_AC.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("ContactName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("SupplierName")
                        .IsRequired();

                    b.Property<string>("URL")
                        .IsRequired();

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("tbkk_AC.Models.Update_License", b =>
                {
                    b.Property<int>("UpdateLicenseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachfiles")
                        .IsRequired();

                    b.Property<int>("Company_CompanyID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<string>("Employee")
                        .IsRequired();

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("LicenseName")
                        .IsRequired();

                    b.Property<int>("License_LicenseID");

                    b.Property<int>("Model_ModelID");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("PONumber")
                        .IsRequired();

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("SoftewareName")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Supplier_SupplierID");

                    b.HasKey("UpdateLicenseID");

                    b.ToTable("Update_License");
                });

            modelBuilder.Entity("tbkk_AC.Models.Asset", b =>
                {
                    b.HasOne("tbkk_AC.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("Supplier_SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tbkk_AC.Models.Employee", b =>
                {
                    b.HasOne("tbkk_AC.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("Company_CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeType_EmployeeTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("Location_LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("Position_PositionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Asset_Asset", b =>
                {
                    b.HasOne("tbkk_AC.Models.Asset", "AssetMom")
                        .WithMany()
                        .HasForeignKey("AssetMomAssetID");
                });

            modelBuilder.Entity("tbkk_AC.Models.Model", b =>
                {
                    b.HasOne("tbkk_AC.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("Brand_BrandID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
