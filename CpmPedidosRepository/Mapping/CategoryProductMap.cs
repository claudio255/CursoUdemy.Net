using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class CategoryProductMap : BaseDomainMap<CategoryProduct>
    {
        public CategoryProductMap(): base("tb_categoria_produto") { }

        public override void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Active).HasColumnName("Active")
                .IsRequired();
        }
    }
}