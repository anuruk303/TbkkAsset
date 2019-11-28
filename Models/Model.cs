using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        [Display(Name = "ModelName")]
        public string ModelName { get; set; }

        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [ForeignKey("Brand")]
        public int Brand_BrandID { get; set; }
        public Brand Brand { get; set; }

        [ForeignKey("Category")]
        public int Category_CategoryID { get; set; }
        public Category Category { get; set; }

        public static implicit operator Model(List<Model> v)
        {
            throw new NotImplementedException();
        }
    }
}
