﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Update_Network
    {
        [Key]
        public int NetworkUpdateID { get; set; }
        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
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

        public int Employee_EmpID { get; set; }
     
        public int Network_NetworkID { get; set; }
    }
}
