using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class Code
    {
        [Key]
        public int CodeId { get; set; }

        [MaxLength(20), Required]
        public string CodeString { get; set; }
    }
}
