namespace Lab3WebAPI.Entities
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public Role Role { get; set; }
    }
}
