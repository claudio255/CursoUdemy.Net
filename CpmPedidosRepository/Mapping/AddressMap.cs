using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class AddressMap : BaseDomainMap<Address>
    {
        AddressMap(): base("tb_endereco") { }

        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);
        }
    }
}