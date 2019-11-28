using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Display(Name = "CategoryName")]
        public string CategoryName { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "TypeName")]
        public string TypeName { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
