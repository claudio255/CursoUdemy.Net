using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class CityMap : BaseDomainMap<City>
    {
        public CityMap(): base("tb_cidade") { }

        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Uf).HasColumnName("uf")
                .HasMaxLength(2)
                .IsRequired();
            builder.Property(x => x.Active).HasColumnName("Active")
                .IsRequired();
        }
    }
}