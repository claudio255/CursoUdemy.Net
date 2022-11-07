using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ComboMap : BaseDomainMap<Combo>
    {
        ComboMap(): base("tb_combo") { }

        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);
        }
    }
}