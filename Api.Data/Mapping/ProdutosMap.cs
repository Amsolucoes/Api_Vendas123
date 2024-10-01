using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class ProdutosMap : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired(true);

            builder.Property(p => p.Quantidade)
                .IsRequired(true);

            builder.Property(p => p.ValorUnitario)
                .IsRequired(true);

            builder.Property(p => p.Desconto)
                .IsRequired(true);

            builder.Property(p => p.ValorTotal)
                .IsRequired(true);

            builder.Property(p => p.Cancelado)
                .IsRequired(true);

            builder.HasOne(p => p.Venda)
                .WithMany(p => p.Produto)
                .HasForeignKey("Id_Venda")
                .HasConstraintName("Fk_Id_Venda_Venda");
        }
    }
}
