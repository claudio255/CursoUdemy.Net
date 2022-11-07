using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ProductMap : BaseDomainMap<Product>
    {
        ProductMap(): base("tb_produto") { }

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
        }
    }
}