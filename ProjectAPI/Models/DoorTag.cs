using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class DoorTag //Composite key
    {
        public int DoorId { get; set; }

        public Door Door { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }

       
    }
}

