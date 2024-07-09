using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlLite.API.Models;

namespace SqlLite.API.Database.Configurations;

internal sealed class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.HasKey(n => n.Id);

        builder.HasAlternateKey(n => n.UserId);

        builder.Property(n => n.Message).IsRequired().HasMaxLength(200);

        builder.Property(n => n.IsRead).IsRequired();

        builder.Property(n => n.CreatedAt).IsRequired();
    }
}
