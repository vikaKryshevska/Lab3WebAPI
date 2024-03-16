using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Lab3WebAPI.Entities;

namespace Lab3WebAPI.Configurations
{
    public class ServiceConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(i => i.Subscribers)
                .WithMany(s => s.Services);

        }
    }
}
