using System.ComponentModel.DataAnnotations;


namespace ProjectAPI.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [MaxLength(20), Required]
        public string TagNumber { get; set; }

        // Navigation property many-to-many relationship with door

        public ICollection<DoorTag> Doors { get; set; }

        // One-to-one relationship with Person
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
