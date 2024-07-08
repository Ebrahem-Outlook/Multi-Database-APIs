using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlServer.API.Models;

namespace SqlServer.API.Database.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.UserName).IsRequired().HasMaxLength(20);

        builder.Property(u => u.Email).IsRequired().HasMaxLength(20);

        builder.Property(u => u.PasswordHash).IsRequired().HasMaxLength(20);
    }
}
