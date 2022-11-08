using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class PromotionProductMap : BaseDomainMap<PromotionProduct>
    {
        public PromotionProductMap(): base("tb_promocao_produto") { }

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

            builder.Property(x => x.IdImage)
                .HasColumnName("Id_image")
                .IsRequired();
            builder.HasOne(x => x.Images)
                .WithMany()
                .HasForeignKey(x => x.IdImage);

            builder.Property(x => x.IdProduct)
            .HasColumnName("Id_product")
            .IsRequired();
            builder.HasOne(x => x.Products)
                .WithMany(x => x.Promotions)
                .HasForeignKey(x => x.IdProduct);
        }
    }
}