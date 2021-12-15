using ProjectAPI.Models;

namespace ProjectAPI.Request
{
    public class LogEntryRequest
    {
        public int Id { get; set; }

        public DateTime WalkedThroughDoor { get; set; }


        public string DoorName { get; set; }
        
        

        public string CodeString { get; set; }
     



        public string TagNumber { get; set; }
       



        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
