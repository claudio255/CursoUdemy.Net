using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class CityMap : BaseDomainMap<City>
    {
        CityMap(): base("tb_cidade") { }

        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
        }
    }
}