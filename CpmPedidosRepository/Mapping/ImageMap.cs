using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class ImageMap : BaseDomainMap<Image>
    {
        public ImageMap(): base("tb_imagem") { }

        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.FileName)
                .HasColumnName("File_Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Main)
                .HasColumnName("Main")
                .IsRequired();
        }
    }
}