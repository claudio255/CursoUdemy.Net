using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class Combo : BaseDomain, IDisplayable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int IdImage { get; set; }
        public virtual Image Images { get; set; }
        
        public virtual List<Product> Products { get; set; }

        public bool Active { get; set; }
    }
}