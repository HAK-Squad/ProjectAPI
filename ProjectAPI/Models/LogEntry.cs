using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class LogEntry // LogEntry from slide 11 contains ("Date", "DoorNumber", "CodeNumber" and "TagNumber")
    {
        [Key]
        public int LogEntryId { get; set; }
        public LogEntry()
        {
            CreatedOn = DateTime.Now;
        }
        public DateTime CreatedOn { get; set; } 

        public Door Door { get; set; }
        public string DoorNumber { get; set; } 

        public Code Code { get; set; }
        public string CodeString { get; set; }

        public Tag Tag { get; set; }
        public string TagNumber { get; set; }

    }
}
