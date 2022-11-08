namespace CpmPedidosDomain.Entities
{
    public class ProductCombo
    {
        public int IdProduct { get; set; }
        public virtual Product Product { get; set; }

        public int IdCombo { get; set; }
        public virtual Combo Combo { get; set; }
    }
}