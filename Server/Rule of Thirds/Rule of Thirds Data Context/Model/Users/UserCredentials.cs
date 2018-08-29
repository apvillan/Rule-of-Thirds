using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rule_of_Thirds_Data_Context.Model.Users
{
    public class UserCredentials
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(64)]
        public string Password { get; set; }

        public ICollection<Claims> Claims { get; set; }
        // public ICollection<SecurityAccount> SecurityQandAs { get; set; }
    }
}
