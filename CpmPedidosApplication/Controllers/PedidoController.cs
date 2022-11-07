using Microsoft.AspNetCore.Mvc;

namespace CpmPedidosApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : AppBaseController
    {
        public PedidoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}