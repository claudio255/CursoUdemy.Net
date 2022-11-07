using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class RequestProductMap : BaseDomainMap<RequestProduct>
    {
        RequestProductMap(): base("tb_produto_pedido") { }

        public override void Configure(EntityTypeBuilder<RequestProduct> builder)
        {
            base.Configure(builder);
        }
    }
}