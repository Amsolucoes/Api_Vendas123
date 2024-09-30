using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class VendasMap : IEntityTypeConfiguration<ComprarEntity>
    {
        public void Configure(EntityTypeBuilder<ComprarEntity> builder)
        {
            builder.ToTable("Vendas");

            builder.HasKey(x => x.Id);

            builder.Property(b => b.Numero)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.DataVenda)
                .IsRequired();

            builder.Property(b => b.Cliente)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(b => b.ValorTotalVendas)
                .IsRequired();

            builder.Property(b => b.Filial)
                .IsRequired();

        }
    }
}
