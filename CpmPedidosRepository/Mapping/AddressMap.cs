using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidosRepository.Mapping
{
    public class AddressMap : BaseDomainMap<Address>
    {
        public AddressMap(): base("tb_endereco") { }

        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Type)
                .HasColumnName("Type")
                .IsRequired();
            builder.Property(x => x.Street)
                .HasColumnName("Street")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.District)
                .HasColumnName("District")
                .HasMaxLength(75)
                .IsRequired();
            builder.Property(x => x.Number)
                .HasColumnName("Number")
                .HasMaxLength(10);
            builder.Property(x => x.Complement)
                .HasColumnName("Complement")
                .HasMaxLength(75);
            builder.Property(x => x.Cep)
                .HasColumnName("Cep")
                .HasMaxLength(8);

            builder.HasOne(x => x.Clients)
                .WithOne(x => x.Addresses)
                .HasForeignKey<Client>(x => x.IdAddress);

            builder.Property(x => x.IdCity)
                .HasColumnName("Id_City")
                .IsRequired();

            builder.HasOne(x => x.Cities)
                .WithMany()
                .HasForeignKey(x => x.IdCity);
        }
    }
}