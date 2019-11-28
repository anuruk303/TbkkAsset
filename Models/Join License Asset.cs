using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Join_License_Asset
    {
        [Key]
        public int JoinLiAsID { get; set; }

        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [ForeignKey("License")]
        public int License_LicenseID { get; set; }
        public License License { get; set; }

        [ForeignKey("Asset")]
        public int Asset_AssetID { get; set; }
        public Asset Asset { get; set; }
    }
}
