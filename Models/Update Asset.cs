using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Update_Asset
    {
        [Key]
        public int UpdateAssetID { get; set; }
        [Required]
        [Display(Name = "Date")]
        public DateTime UpdateDate { get; set; }
        [Required]
        [Display(Name = "AssetName")]
        public string UpdateAssetName { get; set; }

        [Required]
        [Display(Name = "SerailNumber")]
        public string UpdateSerailNumber { get; set; }
        [Required]
        [Display(Name = "MACAddr")]
        public string UpdateMACAddr { get; set; }
        [Required]
        [Display(Name = "InstallDate")]
        public DateTime UpdateInstallDate { get; set; }
        [Required]
        [Display(Name = "PurchaseDate")]
        public DateTime UpdatePurchaseDate { get; set; }
        [Required]
        [Display(Name = "ExpireDate")]
        public DateTime UpdateExpireDate { get; set; }
        [Required]
        [Display(Name = "PONumber")]
        public string UpdatePONumber { get; set; }
        [Required]
        [Display(Name = "Note")]
        public string UpdateNote { get; set; }
        [Required]
        [Display(Name = " Price")]
        public string UpdatePrice { get; set; }
        [Required]
        [Display(Name = " Warranty")]
        public int UpdateWarranty { get; set; }
        [Required]
        [Display(Name = " Type:")]
        public string UpdateType { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string UpdateStatus { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string UpdateImage { get; set; }
      
        public int Location_LocationID { get; set; }

        public int Company_CompanyID { get; set; }

        public int Department_DepartmentID { get; set; }

        public int Supplier_SupplierID { get; set; }

        public int Employee_EmpID { get; set; }

        public int Asset_AssetID { get; set; }

        public int Model_ModelID { get; set; }

    }
}
