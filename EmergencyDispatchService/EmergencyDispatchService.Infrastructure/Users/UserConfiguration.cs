using EmergencyDispatchService.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmergencyDispatchService.Infrastructure.Users;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder .HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedNever();

        builder.Property("FirstName")
            .HasColumnName("FirstName");

        builder.Property("LastName")
            .HasColumnName("LastName");

        builder.Property("PhoneNumber")
            .HasColumnName("PhoneNumber");
    }
}