using CpmPedidosDomain.Interfaces;

namespace CpmPedidosDomain.Entities
{
    public class Product : BaseDomain, IDisplayable
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int IdCategoryProduct { get; set; }
        public virtual CategoryProduct Category { get; set; }

        public virtual List<Image> Images { get; set; }

        public virtual List<PromotionProduct> Promotions { get; set; }

        public virtual List<Combo> Combos { get; set; }

        public bool Active { get; set; }
    }
}