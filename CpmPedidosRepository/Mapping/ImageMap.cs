using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ImageMap : BaseDomainMap<Image>
    {
        ImageMap(): base("tb_imagem") { }

        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);
        }
    }
}