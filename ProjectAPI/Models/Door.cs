using System.ComponentModel.DataAnnotations;


namespace ProjectAPI.Models
{
    public class Door
    {
        [Key] //Creating the Identity 
        public int DoorId { get; set; }

        [MaxLength(30), Required] //Setting the limit and that it can't be Null (NotNull)
        public string DoorName { get; set; }

        // Many-to-many relationship with Tag
        public ICollection<DoorTag> Tags { get; set; }


    }
}
