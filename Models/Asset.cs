using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace tbkk_AC.Models
{
    public class Asset
    {

        public int AssetID { get; set; }
        [Required]
        [Display(Name = "AssetName")]
        public string AssetName { get; set; }

        [Required]
        [Display(Name = "Serail Number")]
        public string SerailNumber { get; set; }

        [Required]
        [Display(Name = "MAC Address")]
        public string MACAddr { get; set; }

        [Required]
        [Display(Name = "Install Date")]
        public DateTime InstallDate { get; set; }

        [Required]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [Display(Name = "Expire Date")]
        public DateTime ExpireDate { get; set; }

        [Required]
        [Display(Name = "PO Number")]
        public string PONumber { get; set; }

        [Required]
        [Display(Name = "Price")]
        public string Price { get; set; }

        [Required]
        [Display(Name = "Warranty")]
        public int Warranty { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        public int Company_CompanyID { get; set; }

        public int Location_LocationID { get; set; }

        public int Department_DepartmentID { get; set; }


        [ForeignKey("Supplier")]
        public int Supplier_SupplierID { get; set; }
        public Supplier Supplier { get; set; }


        public int Employee_EmployeeID { get; set; }


    }
}
