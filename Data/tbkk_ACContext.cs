using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Models
{
    public class tbkk_ACContext : DbContext
    {
        public tbkk_ACContext (DbContextOptions<tbkk_ACContext> options)
            : base(options)
        {
        }

        public DbSet<tbkk_AC.Models.Brand> Brand { get; set; }

        public DbSet<tbkk_AC.Models.Category> Category { get; set; }

        public DbSet<tbkk_AC.Models.Department> Department { get; set; }

        public DbSet<tbkk_AC.Models.Model> Model { get; set; }


        public DbSet<tbkk_AC.Models.Supplier> Supplier { get; set; }

        public DbSet<tbkk_AC.Models.Company> Company { get; set; }

        public DbSet<tbkk_AC.Models.Asset> Asset { get; set; }

        public DbSet<tbkk_AC.Models.Location> Location { get; set; }

        public DbSet<tbkk_AC.Models.Employee> Employee { get; set; }

        public DbSet<tbkk_AC.Models.Network> Network { get; set; }

        public DbSet<tbkk_AC.Models.Position> Position { get; set; }

        public DbSet<tbkk_AC.Models.EmployeeType> EmployeeType { get; set; }

        public DbSet<tbkk_AC.Models.License> License { get; set; }
    }
}
