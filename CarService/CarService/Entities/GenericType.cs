using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCore.Entities
{
    public class GenericType 
    {
        [Key]
        public long ID { set; get; }
        public string Name { set; get; } = string.Empty;
    }
}
