using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class PromotionProductMap : BaseDomainMap<PromotionProduct>
    {
        PromotionProductMap(): base("tb_promocao_produto") { }

        public override void Configure(EntityTypeBuilder<PromotionProduct> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
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