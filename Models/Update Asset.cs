using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Update_Asset
    {
        public int UpdateAssetID { get; set; }
        [Required]
        [Display(Name = "AssetName")]
        public string AssetName { get; set; }
        [Required]
        [Display(Name = "SerailNumber")]
        public string SerailNumber { get; set; }
        [Required]
        [Display(Name = "MACAddr")]
        public string MACAddr { get; set; }
        [Required]
        [Display(Name = "InstallDate")]
        public string InstallDate { get; set; }
        [Required]
        [Display(Name = "PurchaseDate")]
        public DateTime PurchaseDate { get; set; }
        [Required]
        [Display(Name = "ExpireDate")]
        public DateTime ExpireDate { get; set; }
        [Required]
        [Display(Name = "PONumber")]
        public DateTime PONumber { get; set; }
        [Required]
        [Display(Name = " Price")]
        public double Price { get; set; }
        [Required]
        [Display(Name = " Warranty")]
        public int Warranty { get; set; }
        [Required]
        [Display(Name = " Type:")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        public int Location_LocationID { get; set; }

        public int Company_CompanyID { get; set; }

        public int Department_DepartmentID { get; set; }

        public int Supplier_SupplierID { get; set; }

        public int Employee_EmpID { get; set; }

        public int Model_ModelID { get; set; }

    }
}
