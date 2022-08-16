using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyQuizzApplication.Entities.Configuration;

public class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).ValueGeneratedOnAdd();
        builder.Property(b => b.CreatedAt).HasColumnType("datetime").IsRequired();
        builder.Property(b => b.UpdatedAt).HasColumnType("datetime").IsRequired();
    }
}
