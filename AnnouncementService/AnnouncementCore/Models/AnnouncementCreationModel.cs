using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementCore.Models
{
    public class AnnouncementCreationModel
    {
        [Required]
        public long OwnerID { set; get; }
        [Required]
        public bool IsSold { set; get; }
        [Required]
        public long CarID { set; get; }
        public string Description { set; get; } = string.Empty;
        [Required]
        public double Price { set; get; }
    }
}
