using Microsoft.AspNetCore.Identity;

namespace ResumeManagementAPI.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
    }
}
