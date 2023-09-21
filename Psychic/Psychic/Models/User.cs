using System.ComponentModel.DataAnnotations;

namespace Psychic.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public int UserName { get; set; }

        [Required]
        public int Password { get; set; }
    }
}
