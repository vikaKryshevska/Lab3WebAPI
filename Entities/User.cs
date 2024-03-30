using Microsoft.AspNetCore.Identity;

namespace Lab3WebAPI.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Service> Services { get; set; }

        public ICollection<Bill> Bills { get; set; }
        public string Token { get; set; }
    }
}
