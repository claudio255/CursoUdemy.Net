using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ProductMap : BaseDomainMap<Product>
    {
        ProductMap(): base("tb_produto") { }

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Code)
                .HasColumnName("Code")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .HasPrecision(17, 2)
                .IsRequired();
            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .IsRequired();
        }
    }
}