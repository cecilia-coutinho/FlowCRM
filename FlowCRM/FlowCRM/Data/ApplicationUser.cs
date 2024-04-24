using Microsoft.AspNetCore.Identity;

namespace FlowCRM.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? SocialSecurityNumber { get; set; }
    }

}
