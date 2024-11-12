using CursosApp.Model;
using Microsoft.AspNetCore.Identity;

namespace CursosApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CursosAppUser : IdentityUser
    {
        public Profesor? Profesor { get; set; }
    }
}
