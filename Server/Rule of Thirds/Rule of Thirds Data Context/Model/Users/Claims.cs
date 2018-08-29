using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rule_of_Thirds_Data_Context.Model.Users
{
    public class Claims
    {
        // Primary Key to Claims Model
        [Key]
        public int ClaimID { get; set; }

        // Foreign Key to User Model
        [ForeignKey("UserCredentials")]
        public int UserID { get; set; }

        // Stores the Claim Value
        public string Value { get; set; }

        // Stores the Claim Type
        public string Type { get; set; }

        // Navigation Property to User Model
        public virtual UserCredentials UserCredentials { get; set; }
    }
}
