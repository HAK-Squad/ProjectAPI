using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [MaxLength(20), Required]
        public string TagNumber { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public Door Door { get; set; }
        public int DoorId { get; set; }

    }
}
