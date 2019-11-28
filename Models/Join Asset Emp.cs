using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Join_Asset_Emp
    {
        [Key]
        public int JoinAsEmpID { get; set; }
        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [ForeignKey("Employee")]
        public int Employee_EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Asset")]
        public int Asset_AssetID { get; set; }
        public Asset Asset { get; set; }
    }
}
