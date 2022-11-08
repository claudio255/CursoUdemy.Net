using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class RequestProductMap : BaseDomainMap<RequestProduct>
    {
        RequestProductMap(): base("tb_produto_pedido") { }

        public override void Configure(EntityTypeBuilder<RequestProduct> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Quantity)
                .HasColumnName("Quantity")
                .HasPrecision(2)
                .IsRequired();
            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .HasPrecision(17, 2)
                .IsRequired();

            builder.Property(x => x.IdRequest)
                .HasColumnName("Id_request")
                .IsRequired();
            builder.HasOne(x => x.Requests)
                .WithMany(x => x.RequestsProducts)
                .HasForeignKey(x => x.IdRequest);

            builder.Property(x => x.IdProduct)
                .HasColumnName("Id_product")
                .IsRequired();
            builder.HasOne(x => x.Products)
                .WithMany()
                .HasForeignKey(x => x.IdRequest);
        }
    }
}