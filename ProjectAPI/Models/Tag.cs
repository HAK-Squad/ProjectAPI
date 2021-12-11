using System.ComponentModel.DataAnnotations;


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
