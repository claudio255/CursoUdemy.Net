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
        }
    }
}