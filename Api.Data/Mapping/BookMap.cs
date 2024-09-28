using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class BookMap : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.Price)
                .IsRequired();

            builder.OwnsOne(b => b.specifications, specifications =>
            {
                specifications.Property(s => s.OriginallyPublished);

                specifications.Property(s => s.Author)
                .HasMaxLength(60);

                specifications.Property(s => s.PageCount);

                specifications.Property(s => s.Illustrator);

                specifications.Property(s => s.Genres);
            });
        }
    }
}
