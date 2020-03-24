using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class License
    {
        [Key]
        public int LicenseID { get; set; }
        [Required]
        [Display(Name = "LicenseName")]
        public string LicenseName { get; set; }
     
        [Display(Name = "SoftewareName")]
        public string SoftewareName { get; set; }
      
        [Display(Name = "PurchaseDate")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
     
        [Display(Name = "StartDate")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
      
        [Display(Name = "ExpireDate")]
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }
        [Required]
        [Display(Name = "PONumber")]
        public string PONumber { get; set; }
     
        [Display(Name = "Attachfiles")]
        public string Attachfiles { get; set; }
   
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        public int Supplier_SupplierID { get; set; }

        public int Department_DepartmentID { get; set; }

        public int Company_CompanyID { get; set; }

    }
}
