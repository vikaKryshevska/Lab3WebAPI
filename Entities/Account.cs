using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace Lab3WebAPI.Entities
{
    public class Account : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
