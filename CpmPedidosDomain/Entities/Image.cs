namespace CpmPedidosDomain.Entities
{
    public class Image : BaseDomain
    {
        public string Name { get; set; }
        public string FileName { get; set; }

        public bool Main { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}