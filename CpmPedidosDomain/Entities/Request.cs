namespace CpmPedidosDomain.Entities
{
    public class Request : BaseDomain
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public TimeSpan Delivery { get; set; }

        public int IdClient { get; set; }
        public virtual Client Client { get; set; }
        
        public virtual List<RequestProduct> RequestsProducts { get; set; }
    }
}