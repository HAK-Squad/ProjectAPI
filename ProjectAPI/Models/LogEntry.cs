using System.ComponentModel.DataAnnotations;


namespace ProjectAPI.Models
{
    public class LogEntry // LogEntry from slide 11 contains ("Date", "DoorNumber", "CodeNumber" and "TagNumber")
    {
        [Key]
        public int LogEntryId { get; set; }

        public DateTime WalkedThroughDoor { get; set; }


        public string DoorName { get; set; }
        public Door Door { get; set; }

        public string CodeString { get; set; }
        public Code Code { get; set; }


        public string TagNumber { get; set; }
        public Tag Tag { get; set; }

        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        




    }
}
