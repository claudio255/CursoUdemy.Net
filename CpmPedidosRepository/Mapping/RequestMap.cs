using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class RequestMap : BaseDomainMap<Request>
    {
        public RequestMap(): base("tb_pedido") { }

        public override void Configure(EntityTypeBuilder<Request> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Number)
                .HasColumnName("Number")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(x => x.Amount)
                .HasColumnName("Amount")
                .HasPrecision(17, 2)
                .IsRequired();
            builder.Property(x => x.Delivery)
                .HasColumnName("Delivery");

            builder.Property(x => x.IdClient)
                .HasColumnName("Id_client")
                .IsRequired();
            builder.HasOne(x => x.Client)
                .WithMany(x => x.Requests)
                .HasForeignKey(x => x.IdClient);
        }
    }
}