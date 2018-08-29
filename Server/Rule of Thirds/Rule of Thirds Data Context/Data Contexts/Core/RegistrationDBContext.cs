using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Rule_of_Thirds_Data_Context.Model.Users;

namespace Rule_of_Thirds_Data_Context.Data_Contexts.Core
{
    public class RegistrationDBContext: DbContext
    {
        public RegistrationDBContext() : base("RuleOfThirds") { }
        public DbSet<UserCredentials> UserCredentials { get; set; }
        public DbSet<Claims> Claims { get; set; }
    }
}
