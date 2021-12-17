using System.ComponentModel.DataAnnotations;


namespace ProjectAPI.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [MaxLength(20), Required]
        public string FirstName { get; set; }

        [MaxLength(20), Required]
        public string LastName { get; set; }

        [MaxLength(20), Required]
        public string ApertmentNumber { get; set; }


        [MaxLength(20), Required]
        public string TagNumber { get; set; }
    }
}
