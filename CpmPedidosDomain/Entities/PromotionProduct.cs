using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class PromotionProduct : BaseDomain, IDisplayable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int IdImage { get; set; }
        public virtual Image Images { get; set; }
        
        public int IdProduct { get; set; }
        public virtual Product Products { get; set; }

        public bool Active { get; set; }
    }
}