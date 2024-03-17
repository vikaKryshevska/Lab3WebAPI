using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Lab3WebAPI.Entities
{
    // [Table("AspNetUsers")]
    public partial class Account : IdentityUser<Guid>
    {

        public int Id { get; set; }
        public Guid IdentityRoleId { get; set; }
        public virtual IdentityRole IdentityRole { get; set; }

    }
}
