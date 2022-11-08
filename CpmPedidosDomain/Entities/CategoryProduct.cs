using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class CategoryProduct : BaseDomain, IDisplayable
    {
        public string Name { get; set; }

        public bool Active { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}