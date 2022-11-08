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

            builder.Property(x => x.IdImage)
                .HasColumnName("Id_image")
                .IsRequired();
            builder.HasOne(x => x.Images)
                .WithMany()
                .HasForeignKey(x => x.IdImage);

            builder.HasMany(x => x.Products)
                .WithMany(x => x.Combos)
                .UsingEntity<ProductCombo>(
                x => x.HasOne(f => f.Product)
                .WithMany()
                .HasForeignKey(f => f.IdProduct),
                x => x.HasOne(f => f.Combo)
                .WithMany()
                .HasForeignKey(f => f.IdCombo),
                x =>
                {
                    x.ToTable("tb_product_combo");

                    x.HasKey(f => new
                    {
                        f.IdProduct,
                        f.IdCombo
                    });

                    x.Property(x => x.IdProduct)
                    .HasColumnName("id_product")
                    .IsRequired();
                    x.Property(x => x.IdCombo)
                   .HasColumnName("id_combo")
                   .IsRequired();
                });
        }
    }
}