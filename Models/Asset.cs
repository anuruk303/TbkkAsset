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
  
        [Display(Name = "AssetName")]
        public string AssetName { get; set; }

  
        [Display(Name = "Serail Number")]
        public string SerailNumber { get; set; }

     
        [Display(Name = "MAC Address")]
        public string MACAddr { get; set; }

      
        [Display(Name = "Install Date")]
        [DataType(DataType.Date)]
        public DateTime InstallDate { get; set; }

    
        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

    
        [Display(Name = "Expire Date")]
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }

        [Required]
        [Display(Name = "PO Number")]
        public string PONumber { get; set; }

    
        [Display(Name = "Price")]
        public string Price { get; set; }

     
        [Display(Name = "Warranty")]
        public int Warranty { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int Category { get; set; }

  
        [Display(Name = "Note")]
        public string Note { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

    
        [Display(Name = "Image")]
        public string Image { get; set; }

        public int Company_CompanyID { get; set; }

        public int Location_LocationID { get; set; }

        public int Department_DepartmentID { get; set; }

       
        public int Supplier_SupplierID { get; set; }

        public int Model_ModelID { get; set; }
    }
}
