namespace CpmPedidosDomain.Entities
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public DateTime CreatedIn { get; set; }
    }
}