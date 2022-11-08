using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ComboMap : BaseDomainMap<Combo>
    {
        ComboMap(): base("tb_combo") { }

        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(60)
                .IsRequired();
            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .HasPrecision(17, 2)
                .IsRequired();
            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .IsRequired();
        }
    }
}