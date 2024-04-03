using Microsoft.AspNetCore.Identity;

namespace WebAppMVC.Entities
{
    public class ApplicationUser : IdentityUser

    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

    }
}
