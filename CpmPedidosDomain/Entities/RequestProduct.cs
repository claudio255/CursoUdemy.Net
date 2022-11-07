using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class RequestProduct : BaseDomain
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int IdProduct { get; set; }
        public virtual Product Products { get; set; }

        public int IdRequest { get; set; }
        public virtual Request Requests { get; set; }
    }
}