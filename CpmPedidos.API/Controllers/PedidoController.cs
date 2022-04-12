using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CpmPedidos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : AppBaseController
    {
        public PedidoController(IServiceProvider serviceProvider): base (serviceProvider)
        {
        }

    }
}