using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class PromotionProductMap : BaseDomainMap<PromotionProduct>
    {
        PromotionProductMap(): base("tb_promocao_produto") { }

        public override void Configure(EntityTypeBuilder<PromotionProduct> builder)
        {
            base.Configure(builder);
        }
    }
}