using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class Client : BaseDomain, IDisplayable
    {
        public string Name { get; set; }
        public string Cpf { get; set; }

        public int IdAddress { get; set; }
        public virtual Address Addresses { get; set; }

        public bool Active { get; set; }
    }
}