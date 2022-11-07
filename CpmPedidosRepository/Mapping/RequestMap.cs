using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class RequestMap : BaseDomainMap<Request>
    {
        RequestMap(): base("tb_pedido") { }

        public override void Configure(EntityTypeBuilder<Request> builder)
        {
            base.Configure(builder);
        }
    }
}