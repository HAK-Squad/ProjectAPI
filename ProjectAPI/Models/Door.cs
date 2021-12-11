using System.ComponentModel.DataAnnotations;


namespace ProjectAPI.Models
{
    public class Door
    {
        [Key] //Creating the Identity 
        public int DoorId { get; set; }

        [MaxLength(30), Required] //Setting the limit and that it can't be Null (NotNull)
        public string DoorNumber { get; set; }

        [MaxLength(30), Required]
        public string DoorLocation { get; set; }

        public Code Code { get; set; } //Creating the association

        public int CodeId { get; set; } //Instering the foreign key 
    }
}
