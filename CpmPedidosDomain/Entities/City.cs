using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class City : BaseDomain, IDisplayable
    {
        public string Name { get; set; }
        public string Uf { get; set; }
        public bool Active { get; set; }
    }
}