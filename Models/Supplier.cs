using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [Required]
        [Display(Name = "SupplierName")]
        public string SupplierName { get; set; }
        [Display(Name = "ContactName")]
        public string ContactName { get; set; }
    
        [Display(Name = "Address")]
        public string Address { get; set; }
     
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Display(Name = "URL")]
        public string URL { get; set; }
       
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        
    }
}
