using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using creditcardapi.Models;

namespace creditcardapi.Controllers
{
    [ApiController]
    [Route("v1/cliente")]
    public class ClienteController : ControllerBase {

        [HttpGet]
        [Route("{email}")]
        public async Task<ActionResult<List<Cliente>>> Get([FromServices] AppDbContext context, string email)
        {   
            var clientes = await context.Cliente
                .Where(client => client.email.Equals(email))
                .Include(client => client.cartoes)
                .ToListAsync();
            return clientes;
        }
    }
}