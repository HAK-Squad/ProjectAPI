using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Code
    {
        [Key]
        public int CodeId { get; set; }

        [MaxLength(20), Required]
        public string CodeString { get; set; }
    }
}
