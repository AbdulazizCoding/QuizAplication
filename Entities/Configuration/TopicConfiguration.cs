using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyQuizzApplication.Entities.Configuration;

namespace MyQuizzApplication.Entities.Configuration;

public class TopicConfiguration : EntityBaseConfiguration<Topic>
{
    public override void Configure(EntityTypeBuilder<Topic> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.Name).HasColumnType("varchat(50)").IsRequired(true);
        builder.Property(p => p.Description).HasColumnType("nvarchat(255)").IsRequired(true);
        builder.Property(p => p.NameHash).HasColumnType("chat(64)").IsRequired(true);
        builder.HasIndex(p => p.NameHash).IsUnique(true);
    }
}