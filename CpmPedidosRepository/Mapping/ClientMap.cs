using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ClientMap : BaseDomainMap<Client>
    {
        ClientMap(): base("tb_cliente") { }

        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(60)
                .IsRequired();
            builder.Property(x => x.Cpf)
                .HasColumnName("Cpf")
                .HasMaxLength(11)
                .IsRequired();
            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .IsRequired();
        }
    }
}