using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ClientMap : BaseDomainMap<Client>
    {
        ClientMap(): base("tb_cliente") { }

        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);
        }
    }
}