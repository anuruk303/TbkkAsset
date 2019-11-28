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
        [Required]
        [Display(Name = "ContactName")]
        public string ContactName { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "URL")]
        public string URL { get; set; }
        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        public static implicit operator Supplier(List<Supplier> v)
        {
            throw new NotImplementedException();
        }
    }
}
