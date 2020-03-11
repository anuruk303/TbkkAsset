﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        [Required]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

  
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
