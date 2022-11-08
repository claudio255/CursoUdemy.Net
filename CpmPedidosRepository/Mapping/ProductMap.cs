using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ProductMap : BaseDomainMap<Product>
    {
        public ProductMap() : base("tb_produto") { }

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Code)
                .HasColumnName("Code")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .HasPrecision(17, 2)
                .IsRequired();
            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .IsRequired();

            builder.Property(x => x.IdCategoryProduct)
            .HasColumnName("Id_category_product")
            .IsRequired();
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.IdCategoryProduct);

            builder.HasMany(x => x.Images)
                .WithMany(x => x.Products)
                .UsingEntity<ImageProduct>(
                x => x.HasOne(f => f.Image)
                .WithMany()
                .HasForeignKey(f => f.IdImage),
                x => x.HasOne(f => f.Product)
                .WithMany()
                .HasForeignKey(f => f.IdProduct),
                x =>
                {
                    x.ToTable("tb_image_product");

                    x.HasKey(f => new
                    {
                        f.IdImage,
                        f.IdProduct
                    });

                    x.Property(x => x.IdImage)
                   .HasColumnName("id_image")
                   .IsRequired();
                    x.Property(x => x.IdProduct)
                    .HasColumnName("id_product")
                    .IsRequired();
                });
        }
    }
}