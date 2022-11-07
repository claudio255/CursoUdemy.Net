using Microsoft.AspNetCore.Mvc;

namespace CpmPedidosApplication.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider _serviceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}