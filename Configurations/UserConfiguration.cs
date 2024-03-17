using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Lab3WebAPI.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    { 
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {

        }
    }
}
