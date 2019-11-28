using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Update_Network
    {
        public int NetworkUpdateID { get; set; }
        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }
        [Required]
        [Display(Name = "IpAddr")]
        public string IpAddr { get; set; }
        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [ForeignKey("EmpID")]
        public int Employee_EmpID { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("NetworkID")]
        public int Network_NetworkID { get; set; }
        public Network Network { get; set; }
    }
}
