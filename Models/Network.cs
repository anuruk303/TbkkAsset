using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Network
    {
        public int NetworkID { get; set; }
        [Required]
        [Display(Name = "NetworkName")]
        public string NetworkName { get; set; }
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
    }
}
