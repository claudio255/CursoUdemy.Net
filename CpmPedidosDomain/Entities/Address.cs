using CpmPedidosDomain.Enums;

namespace CpmPedidosDomain.Entities
{
    public class Address : BaseDomain
    {
        public TypeAddressEnum Type { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; }

        public int IdCity { get; set; }
        public virtual City Cities { get; set; }
    }
}